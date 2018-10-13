using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQuanLyThuVien
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // 1: admin 
            FormUsers f = new FormUsers();
            // 2: users 
            FormAdmin fAd = new FormAdmin();

            //show neither admin or guest
            if (rdAdmin.Checked == true)
            {  
                this.Hide();
                fAd.ShowDialog();
                this.Show();
            }
            else if(rdGuest.Checked == true)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

            //viet dai di giao su
            ////string id, ncc, add;
            //string cnString = "SERVER = .; DATABASE = CoffeeShop; INTEGRATED SECURITY = true";
            //SqlConnection cn = new SqlConnection(cnString);
            //cn.Open();
            //// COUNT username trong database
            ////string sql = "SELECT COUNT(Id) FROM Id WHERE UserName = '" + user + "' AND Password = '" + pass + "'";
            ////string sql = "INSERT INTO Supplier VALUES = '"
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cn;
            ////cmd.CommandText = sql;
            //cmd.CommandType = CommandType.Text;
            ////int row = cmd.ExecuteNonQuery();
            //int count = (int)cmd.ExecuteScalar();// lay gia tri

            //cn.Close();
        }
    }
}
