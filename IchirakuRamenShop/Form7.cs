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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=ichi;Integrated Security=True;Encrypt=False");
        string selectedImagePath = "";

        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                MessageBox.Show("Selected Image: " + selectedImagePath, "Image Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string pname = txtPName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(pname) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(description) || string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please fill all fields and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageBytes = File.ReadAllBytes(selectedImagePath);

            try
            {
                con.Open();

                string query = "INSERT INTO Product (PName, Price, Description, Image) VALUES (@pname, @price, @description, @image)";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pname", pname);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@image", imageBytes);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void ClearForm()
        {
            txtPName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            selectedImagePath = string.Empty;
        }
    }
}
