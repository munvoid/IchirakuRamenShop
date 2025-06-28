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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=rms;Integrated Security=True;Encrypt=False");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadProductGrid();

        }
        private void LoadProductGrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Pid, PName, Price, Image FROM Product", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProducts.DataSource = dt;

                // Set up grid display
                if (!dataGridViewProducts.Columns.Contains("AddToCart"))
                {
                    // Image
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.HeaderText = "Image";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Name = "ProductImage";
                    imgCol.Width = 100;
                    imgCol.DataPropertyName = "Image";
                    dataGridViewProducts.Columns.Add(imgCol);

                    // Add to Cart Button
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Text = "Add to Cart";
                    btn.UseColumnTextForButtonValue = true;
                    btn.Name = "AddToCart";
                    dataGridViewProducts.Columns.Add(btn);
                }

                // Optional: Hide raw image column if bound
                if (dataGridViewProducts.Columns.Contains("Image"))
                    dataGridViewProducts.Columns["Image"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "AddToCart" && e.RowIndex >= 0)
            {
                string pname = dataGridViewProducts.Rows[e.RowIndex].Cells["PName"].Value.ToString();
                MessageBox.Show($"{pname} added to cart!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Add actual cart logic here
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
