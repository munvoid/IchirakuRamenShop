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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=rms;Integrated Security=True;Encrypt=False");

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string name = this.txtName.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string phone = this.txtPhone.Text.Trim();

            string message = "Username: " + username +
                             "\r\nName: " + name +
                             "\r\nPassword: " + password +
                             "\r\nPhone: " + phone;

            DialogResult result = MessageBox.Show(message, "User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                InsertUser(username, name, password);

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Discarding Entry");
            }
        }

        private void InsertUser(string username, string name, string password)
        {
            try
            {
               
                    con.Open();

                    // Optional: Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists. Try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert query (Uid auto-generated with NEWID or IDENTITY in practice; here we use MAX+1)
                    string getMaxIdQuery = "SELECT ISNULL(MAX(Uid), 0) + 1 FROM [User]";
                    SqlCommand getIdCmd = new SqlCommand(getMaxIdQuery, con);
                    int newUid = (int)getIdCmd.ExecuteScalar();

                    string insertQuery = "INSERT INTO [User] (Uid, Username, Role, Name, Password) " +
                                         "VALUES (@uid, @username, @role, @name, @password)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@uid", newUid);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@role", "Customer"); // Default role
                    insertCmd.Parameters.AddWithValue("@name", name);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    int rows = insertCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
