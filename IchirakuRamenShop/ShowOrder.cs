using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace IchirakuRamenShop
{
    public partial class ShowOrder : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1D8R49Q;Initial Catalog=ichi;Integrated Security=True;Encrypt=False");

        public void OrderForm()
        {
            InitializeComponent();
            MessageBox.Show("INITTT");

        }
        private void Order_Load(object sender, EventArgs e)
        {


            MessageBox.Show("Loading Orders");
            LoadOrders();

            MessageBox.Show("Loaded Orders");

        }
        private string GetProductsString(int cartId)
        {
            string query = @"
        SELECT p.PName, s.Quantity
        FROM Stores s
        JOIN Product p ON s.Pid = p.Pid
        WHERE s.Cartid = @CartID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CartID", cartId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable productTable = new DataTable();
            adapter.Fill(productTable);

            List<string> productList = new List<string>();

            foreach (DataRow row in productTable.Rows)
            {
                string name = row["PName"].ToString();
                int qty = Convert.ToInt32(row["Quantity"]);
                productList.Add($"{name} x {qty}");
            }

            return string.Join("\n", productList); // Multiple lines
        }

        private void LoadOrders()
        {
            try
            {
                con.Open();

                // Step 1: Get all unique CartID - CustomerID pairs
                string cartQuery = @"
            SELECT DISTINCT h.Cartid, h.Cid
            FROM Has h
            ORDER BY h.Cartid";

                SqlCommand cmd = new SqlCommand(cartQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Query Outer DOne");
                DataTable orderTable = new DataTable();
                orderTable.Columns.Add("CartID", typeof(int));
                orderTable.Columns.Add("Customer_ID", typeof(int));
                orderTable.Columns.Add("Products", typeof(string));

                List<(int CartID, int CustomerID)> cartList = new List<(int, int)>();

                while (reader.Read())
                {
                    int cartId = reader.GetInt32(0);
                    int customerId = reader.GetInt32(1);
                    cartList.Add((cartId, customerId));
                }

                reader.Close();

                // Step 2: For each CartID, get the product list
                foreach (var (cartId, customerId) in cartList)
                {
                    string products = GetProductsString(cartId);
                    MessageBox.Show("Query Inner DOne");
                    // Add row to DataTable
                    orderTable.Rows.Add(cartId, customerId, products);
                }

                con.Close();

                // Step 3: Bind to Grid
                gridOrder.DataSource = orderTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void Order_Loadx(object sender, EventArgs e)
        {
            MessageBox.Show("Loading");
        }

        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
