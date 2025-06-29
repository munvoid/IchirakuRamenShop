using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IchirakuRamenShop
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=ichi;Integrated Security=True;Encrypt=False");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadUserGrid();
        }
        private void LoadUserGrid()
        {
            try
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Uid, Username, Role, Name, Password FROM Users", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                // Remove old action columns if already added
                if (dataGridView1.Columns.Contains("DeleteUser"))
                    dataGridView1.Columns.Remove("DeleteUser");

                if (dataGridView1.Columns.Contains("MakeStaff"))
                    dataGridView1.Columns.Remove("MakeStaff");

                // Add Delete button column
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Action";
                deleteBtn.Text = "Delete User";
                deleteBtn.UseColumnTextForButtonValue = true;
                deleteBtn.Name = "DeleteUser";
                dataGridView1.Columns.Add(deleteBtn);

                // Add Transform to Staff button column
                DataGridViewButtonColumn transformBtn = new DataGridViewButtonColumn();
                transformBtn.HeaderText = "Promote";
                transformBtn.Text = "Make Staff";
                transformBtn.UseColumnTextForButtonValue = true;
                transformBtn.Name = "MakeStaff";
                dataGridView1.Columns.Add(transformBtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            int uid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Uid"].Value);
            string uname = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            string role = dataGridView1.Rows[e.RowIndex].Cells["Role"].Value.ToString();

            if (columnName == "DeleteUser")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete user '{uname}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    DeleteUser(uid);
                    LoadUserGrid(); // Refresh grid
                }
            }
            else if (columnName == "MakeStaff")
            {
                if (role == "Customer")
                {
                    try
                    {
                        con.Open();

                        // 1. Update role in Users table
                        SqlCommand updateRoleCmd = new SqlCommand("UPDATE Users SET Role = 'Stuff' WHERE Uid = @uid", con);
                        updateRoleCmd.Parameters.AddWithValue("@uid", uid);
                        updateRoleCmd.ExecuteNonQuery();

                        // 2. Insert into Stuff table with default salary
                        SqlCommand insertStuffCmd = new SqlCommand("INSERT INTO Stuff (Salary, Uid) VALUES (@salary, @uid)", con);
                        insertStuffCmd.Parameters.AddWithValue("@salary", 30000); // Default salary
                        insertStuffCmd.Parameters.AddWithValue("@uid", uid);
                        insertStuffCmd.ExecuteNonQuery();

                        MessageBox.Show($"User '{uname}' has been promoted to Staff.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error transforming user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        LoadUserGrid(); // Refresh
                    }
                }
                else
                {
                    MessageBox.Show("Not Allowed. Only Customers can be transformed to Staff.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DeleteUser(int uid)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Uid = @uid", con);
                cmd.Parameters.AddWithValue("@uid", uid);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
