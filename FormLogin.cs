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
            //sinh vien ko can dang nhap 
            //---trong frmAdmin
            // neu sinh vien khong nhap MSSV thi ko cho them
            string userName = txtName.Text;
            string passWord = txtPassword.Text;
            //-----------=============================================================================
            /* 
             *--------original
             * 
             */
            if (Login(userName, passWord))
            {
                // user
                FormUsers f = new FormUsers();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên hoặc mật khẩu , vui lòng thử lại");
            }
            //--==============================================================
            // test paralle admin , guest
            //if(LoginAdmin(userName , passWord) == true)
            //{
            //    FormAdmin fad = new FormAdmin();
            //    this.Hide();
            //    fad.ShowDialog();
            //    this.Show();
            //}
            //else if(LoginGuest(userName , passWord) == true)
            //{
            //    FormAdmin fAd = new FormAdmin();
            //    this.Hide();
            //    fAd.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên hoặc mật khẩu , vui lòng thử lại");
            //}

            ////---=====================================================================================

            //if (LoginGuest(userName, passWord))
            //{
            //    // 2: users 
            //    FormUsers f = new FormUsers();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên hoặc mật khẩu , vui lòng thử lại");
            //}


            //--------====================================================================================
            //noob
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
            //-=======================================================
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

    }
}
