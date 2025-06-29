using System.Data.SqlClient;
using System.Drawing;

namespace IchirakuRamenShop
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=ichi;Integrated Security=True;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;
            Int32 userId = 0;
            string role = "";
            try
            {
                con.Open();
                string query = "SELECT  Uid, Role FROM [Users] WHERE Username = @uname AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@pass", password);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = reader.GetInt32(0);
                    role = reader.GetString(1);

                    if (role == "Customer")
                    {
                        // Fetch Cid from Customer table using userId (Uid)
                        Int32 cid = 0;
                        reader.Close(); // Close previous reader before new command
                        string customerQuery = "SELECT Cid FROM Customer WHERE Uid = @uid";
                        SqlCommand customerCmd = new SqlCommand(customerQuery, con);
                        customerCmd.Parameters.AddWithValue("@uid", userId);
                        object cidResult = customerCmd.ExecuteScalar();
                        if (cidResult != null)
                        {
                            cid = Convert.ToInt32(cidResult);
                            Form5 f5 = new Form5(cid);
                            f5.Show();
                        }
                        else
                        {
                            lblStatus.Text = "Customer record not found.";
                            return;
                        }
                    }
                    else if (role == "Stuff")
                    {
                        Form6 f6 = new Form6();
                        f6.Show();
                    }
                    else if (role == "Admin")
                    {
                        Form4 f4 = new Form4();
                        f4.Show();
                    }

                    this.Hide();
                }
                else
                {
                    lblStatus.Text = "Invalid username or password.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }


        private void btnRedgister_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
