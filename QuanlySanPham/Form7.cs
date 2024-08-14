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

namespace QuanlySanPham
{
    public partial class Form7 : Form
    {
        SqlConnection conn;
        private string connectionString = "Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;";
        public Form7()
        {
            InitializeComponent();
            conn = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show(this, "Connection sucessful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTopSellingProducts();
        }
        private void LoadTopSellingProducts()
        {

            string query = @"
              SELECT TOP 3
             p.product_name,
                 SUM(o.orders_products) AS total_sold
             FROM
                  dbo.orders o
              JOIN
               dbo.product p ON o.product_id = p.product_id
             GROUP BY
               p.product_name
                  ORDER BY
             total_sold DESC;
              ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {

                    connection.Open();
                    adapter.Fill(dataTable);


                    DgvTopSeller.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement product = new FormProductManagement();
            product.ShowDialog();
            this.Dispose();
        }
    }
}
