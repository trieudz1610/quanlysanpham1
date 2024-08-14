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
using System.Xml.Linq;

namespace QuanlySanPham
{
    public partial class FormProductManagement : Form
    {
        SqlConnection connection;
        public FormProductManagement()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["product_id"].Value.ToString();
                txtProductName.Text = row.Cells["product_name"].Value.ToString();
                txtPrice.Text = row.Cells["product_price"].Value.ToString();
                txtQuantity.Text = row.Cells["product_quantity"].Value.ToString();
            }
        }
        private void FillData()
        {
            string query = "SELECT * from product";

            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string id = txtProductID.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lbIdError.Text = "ID can't be blank";
            }
            else
                lbIdError.Text = "";

            string name = txtProductName.Text;
            if (name.Equals(""))
            {
                error = error + 1;
                LbnameError.Text = "Name can't be blank";
            }
            else
                LbnameError.Text = "";

            string price = txtPrice.Text;
            if (price.Equals(""))
            {
                error = error + 1;
                lbPriceError.Text = "Price can't be blank";
            }
            else
                lbPriceError.Text = "";

            string quantity = txtPrice.Text;
            if (quantity.Equals(""))
            {
                error = error + 1;
                lbQuantityError.Text = "Quantity can't be blank";
            }
            else
            {
                string query = "select * from product where product_id = @id";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@id", SqlDbType.Int);
                cmdcheck.Parameters["@id"].Value = id;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbIdError.Text = "THis Id is existing, please choose another";
                }
                else
                {
                    lbQuantityError.Text = "";
                }
                connection.Close();
                if (error == 0)
                {
                    string insert = "Insert into product values (@id,@name,@price,@quantity)";
                    connection.Open();
                    SqlCommand cmdinsert = new SqlCommand(insert, connection);
                    cmdinsert.Parameters.Add("@id", SqlDbType.Int);
                    cmdinsert.Parameters["@id"].Value = id;
                    cmdinsert.Parameters.Add("@name", SqlDbType.VarChar);
                    cmdinsert.Parameters["@name"].Value = name;
                    cmdinsert.Parameters.Add("@price", SqlDbType.Int);
                    cmdinsert.Parameters["@price"].Value = price;
                    cmdinsert.Parameters.Add("@quantity", SqlDbType.Int);
                    cmdinsert.Parameters["@quantity"].Value = quantity;
                    cmdinsert.ExecuteNonQuery();
                    FillData();
                    MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update dbo.product set product_name = @name, product_quantity = @quantity, product_price =@price"
                + " Where product_id = @productid";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = txtProductName.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = txtQuantity.Text;
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters["@price"].Value = txtPrice.Text;
                cmd.Parameters.Add("@productid", SqlDbType.Int);
                cmd.Parameters["@productid"].Value = txtProductID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    MessageBox.Show(this, "Update data successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();

                string delete = "delete from dbo.product where product_id =@productid";

                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@productid", SqlDbType.Int);
                cmd.Parameters["@productid"].Value = txtProductID.Text;

                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Deleted sucessful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTransaction Transaction = new AdminTransaction();
            Transaction.ShowDialog();
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin logout = new FormLogin();
            logout.ShowDialog();
            this.Dispose();
        }

        private void btnCheckTopSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Dispose();
        }
    }
}
