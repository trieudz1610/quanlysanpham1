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
    public partial class AdminTransaction : Form
    {
        SqlConnection conn;
        public AdminTransaction()
        {
            InitializeComponent();
           conn = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement back = new FormProductManagement();
            back.ShowDialog();
            this.Dispose();
        }
        private void FillData()
        {
            string query = "select * from transactions";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tbl);
            dgvTranssaction.DataSource = tbl;
            conn.Close();
        }

        private void AdminTransaction_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
