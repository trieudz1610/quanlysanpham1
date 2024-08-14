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
    public partial class FormLogin : Form
    {
        SqlConnection conn;
        public FormLogin()
        {
            InitializeComponent();
            conn = new SqlConnection("Server=LAPTOP-9CVO4R65; Database=quanly; Integrated Security =true;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;
            string query = "select * from dbo.account where username =@username and u_password =@password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login sucessful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    FormProductManagement p = new FormProductManagement();
                    p.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("customer"))
                {
                    MessageBox.Show(this, "Login sucessful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    ViewProduct vp = new ViewProduct();
                    vp.ShowDialog();
                    this.Dispose();
                }
                else
                    LbError.Text = "You are not allowed to login";
            }
            else
            {
                LbError.Text = "Wrong username or password";
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
