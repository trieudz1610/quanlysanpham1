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
    public partial class ViewProduct : Form
    {
        SqlConnection Connection;
        public ViewProduct()
        {
            InitializeComponent();
            Connection = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }
        private void FillData()
        {
            string query = "select * from transactions";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, Connection);
            ad.Fill(tbl);
            dgvTranssaction.DataSource = tbl;
            Connection.Close();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            Connection.Open();
            FillData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Dispose();
        }

        private void btnCheckInfomation_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInformation information = new CustomerInformation();
            information.ShowDialog();
            this.Dispose();
        }
    }
}
