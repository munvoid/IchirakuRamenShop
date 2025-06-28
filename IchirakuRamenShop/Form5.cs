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
                // Get product details from the selected row
                int pid = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Pid"].Value);
                string pname = dataGridViewProducts.Rows[e.RowIndex].Cells["PName"].Value.ToString();
                decimal price = Convert.ToDecimal(dataGridViewProducts.Rows[e.RowIndex].Cells["Price"].Value);

                // Add to cart
                AddToCart(pid, pname, price);

                MessageBox.Show($"{pname} added to cart!\nTotal items: {GetCartItemCount()}\nTotal amount: ${GetCartTotal():F2}",
                               "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddToCart(int productId, string productName, decimal price)
        {
            // Check if product already exists in cart
            DataRow existingRow = cartTable.AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ProductId") == productId);

            if (existingRow != null)
            {
                // Product exists, increase quantity
                int currentQty = existingRow.Field<int>("Quantity");
                existingRow["Quantity"] = currentQty + 1;
                existingRow["Total"] = (currentQty + 1) * price;
            }
            else
            {
                // Add new product to cart
                DataRow newRow = cartTable.NewRow();
                newRow["ProductId"] = productId;
                newRow["ProductName"] = productName;
                newRow["Price"] = price;
                newRow["Quantity"] = 1;
                newRow["Total"] = price;
                cartTable.Rows.Add(newRow);
            }

            CalculateTotal();
        }

        private void PlaceOrder(int customerId)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            try
            {
                con.Open();

                // 1. Insert into Cart and get new Cartid
                SqlCommand cmdCart = new SqlCommand("INSERT INTO Cart DEFAULT VALUES; SELECT SCOPE_IDENTITY();", con);
                int cartId = Convert.ToInt32(cmdCart.ExecuteScalar());

                // 2. Insert into Has (link customer and cart)
                SqlCommand cmdHas = new SqlCommand("INSERT INTO Has (Cid, Cartid) VALUES (@cid, @cartid)", con);
                cmdHas.Parameters.AddWithValue("@cid", customerId);
                cmdHas.Parameters.AddWithValue("@cartid", cartId);
                cmdHas.ExecuteNonQuery();

                // 3. Insert each cart item into Stores
                foreach (DataRow row in cartTable.Rows)
                {
                    SqlCommand cmdStores = new SqlCommand(
                        "INSERT INTO Stores (Cartid, Pid, Quantity) VALUES (@cartid, @pid, @qty)", con);
                    cmdStores.Parameters.AddWithValue("@cartid", cartId);
                    cmdStores.Parameters.AddWithValue("@pid", row["ProductId"]);
                    cmdStores.Parameters.AddWithValue("@qty", row["Quantity"]);
                    cmdStores.ExecuteNonQuery();
                }

                MessageBox.Show("Order placed successfully!");

                // Optionally clear the cart
                cartTable.Clear();
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CalculateTotal()
        {
            totalAmount = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
