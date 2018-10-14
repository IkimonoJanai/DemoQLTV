using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoQuanLyThuVien.DAO;

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

            // try to input in password secsion ' or 1=1 -- 

            string userName = txtName.Text;
            string passWord = txtPassword.Text;


            if (LoginAdmin(userName, passWord))
            {
                // 1: admin 
                FormAdmin fAd = new FormAdmin();
                this.Hide();
                fAd.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu , vui lòng thử lại");
            }

            //---=====================================================================================

            if (LoginGuest(userName, passWord))
            {
                // 2: users 
                FormUsers f = new FormUsers();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu , vui lòng thử lại");
            }




            //show neither admin or guest
            //if (rdAdmin.Checked == true)
            //{  
            //    this.Hide();
            //    fAd.ShowDialog();
            //    this.Show();
            //}
            //else if(rdGuest.Checked == true)
            //{
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
        }

        bool LoginAdmin(string userName, string passWord)
        {
            return AccountDAO.Instance.LoginAdmin(userName, passWord);
        }
        bool LoginGuest(string userName, string passWord)
        {
            return AccountDAO.Instance.LoginGuest(userName, passWord);
        }
    }
}
