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
    public partial class CustomerInformation : Form
    {
        SqlConnection conn;
        public CustomerInformation()
        {
            InitializeComponent();
            conn = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvCustomer.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells["customer_id"].Value.ToString();
                txtCustomerName.Text = row.Cells["customer_name"].Value.ToString();
                txtCustomerAddress.Text = row.Cells["customer_address"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["customer_phone"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["customer_email"].Value.ToString();
                txtCustomerGender.Text = row.Cells["customer_gender"].Value.ToString();
            }
        }
        private void FillData()
        {
            string query = "select * from dbo.customer";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tbl);
            DgvCustomer.DataSource = tbl;
            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string id = txtCustomerID.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                LbCustomerID.Text = "ID can't be blank";
            }
            else
                LbCustomerID.Text = "";

            string name = txtCustomerName.Text;
            if (name.Equals(""))
            {
                error = error + 1;
                LbCustomerNameError.Text = "Name can't be blank";
            }
            else
                LbCustomerNameError.Text = "";

            string adress = txtCustomerAddress.Text;
            if (adress.Equals(""))
            {
                error = error + 1;
                LbAddressError.Text = "Adress can't be blank";
            }
            else
                LbAddressError.Text = "";

            string email = txtCustomerEmail.Text;
            if (email.Equals(""))
            {
                error = error + 1;
                lbemailError.Text = "Email can't be blank";
            }
            else
                lbemailError.Text = "";

            string phone = txtCustomerPhone.Text;
            if (phone.Equals(""))
            {
                error = error + 1;
                LbPhoneError.Text = "Phone can't be blank";
            }
            else
                LbPhoneError.Text = "";

            string gender = txtCustomerGender.Text;
            if (gender.Equals(""))
            {
                error = error + 1;
                lbGenderError.Text = "Gender can't be blank";
            }
            else
            {
                string query = "select * from dbo.customer where customer_id = @id";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@id", SqlDbType.Int);
                cmdcheck.Parameters["@id"].Value = id;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    LbCustomerID.Text = "THis Id is existing, please choose another";
                }
                else
                {
                    lbGenderError.Text = "";
                }
                conn.Close();
                if (error == 0)
                {
                    string insert = "Insert into dbo.customer values (@id,@name,@adress,@phone,@email,@gender)";
                    conn.Open();
                    SqlCommand cmdinsert = new SqlCommand(insert, conn);
                    cmdinsert.Parameters.Add("@id", SqlDbType.Int);
                    cmdinsert.Parameters["@id"].Value = id;
                    cmdinsert.Parameters.Add("@name", SqlDbType.VarChar);
                    cmdinsert.Parameters["@name"].Value = name;
                    cmdinsert.Parameters.Add("@adress", SqlDbType.VarChar);
                    cmdinsert.Parameters["@adress"].Value = adress;
                    cmdinsert.Parameters.Add("@phone", SqlDbType.Int);
                    cmdinsert.Parameters["@phone"].Value = phone;
                    cmdinsert.Parameters.Add("@gender", SqlDbType.VarChar);
                    cmdinsert.Parameters["@gender"].Value = gender;
                    cmdinsert.Parameters.Add("@email", SqlDbType.VarChar);
                    cmdinsert.Parameters["@email"].Value = email;
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
                string update = "update dbo.customer set customer_name = @name, customer_address =@adress, customer_phone =@phone , customer_email =@email, customer_gender =@gender"
                + " Where customer_id = @customerid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = txtCustomerName.Text;
                cmd.Parameters.Add("@adress", SqlDbType.VarChar);
                cmd.Parameters["@adress"].Value = txtCustomerAddress.Text;
                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = txtCustomerPhone.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = txtCustomerEmail.Text;
                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = txtCustomerGender.Text;
                cmd.Parameters.Add("@customerid", SqlDbType.VarChar);
                cmd.Parameters["@customerid"].Value = txtCustomerID.Text;
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
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerName.Text = "";
            txtCustomerGender.Text = "";
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from dbo.customer where customer_id =@customerid";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@customerid", SqlDbType.Int);
                cmd.Parameters["@customerid"].Value = txtCustomerID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Deleted sucessful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct back = new ViewProduct();
            back.ShowDialog();
            this.Dispose();
        }
    }
}
