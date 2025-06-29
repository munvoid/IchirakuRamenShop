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

                // Remove previous delete column if exists
                if (dataGridView1.Columns.Contains("DeleteUser"))
                    dataGridView1.Columns.Remove("DeleteUser");

                // Add Delete button column
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Action";
                btn.Text = "Delete User";
                btn.UseColumnTextForButtonValue = true;
                btn.Name = "DeleteUser";
                dataGridView1.Columns.Add(btn);
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteUser" && e.RowIndex >= 0)
            {
                int uid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Uid"].Value);
                string uname = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();

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
