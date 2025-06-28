using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IchirakuRamenShop
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRAINSTATION;Initial Catalog=rms;Integrated Security=True;Encrypt=False");

        public Form6()
        {
            InitializeComponent();
        }

        private void LoadProductGrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Pid, PName, Price, Image FROM Product", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                // Set up grid display
                if (!dataGridView1.Columns.Contains("AddToCart"))
                {
                    // Image column
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.HeaderText = "Image";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Name = "ProductImage";
                    imgCol.Width = 100;
                    imgCol.DataPropertyName = "Image";
                    dataGridView1.Columns.Add(imgCol);

                    // Add to Cart button column
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Text = "Add to Cart";
                    btn.UseColumnTextForButtonValue = true;
                    btn.Name = "AddToCart";
                    dataGridView1.Columns.Add(btn);
                }

                // Hide raw binary image column
                if (dataGridView1.Columns.Contains("Image"))
                {
                    dataGridView1.Columns["Image"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteProduct" && e.RowIndex >= 0)
            {
                // Get product details from the selected row
                int pid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Pid"].Value);
                string pname = dataGridView1.Rows[e.RowIndex].Cells["PName"].Value.ToString();
                
                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{pname}'?", 
                                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    DeleteProduct(pid, pname);
                }
            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            LoadProductGrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e) { }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
