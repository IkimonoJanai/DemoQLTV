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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        #region Method
        #endregion

        #region Property
        #endregion

        #region Events
        private void btRent_Click(object sender, EventArgs e)
        {
            /***Đăng nhập***************************************************************************/

            fRentBookLogin fRBL = new fRentBookLogin();
            this.Hide();
            fRBL.ShowDialog();
            this.Show();

            /***Không đăng nhập***************************************************************************/

            //fRentBook fRB = new fRentBook();
            //this.Hide();
            //fRB.ShowDialog();
            //this.Show();
        }

        private void btRentList_Click(object sender, EventArgs e)
        {
            fRentList fRL = new fRentList();
            this.Hide();
            fRL.ShowDialog();
            this.Show();
        }

        private void btBookList_Click(object sender, EventArgs e)
        {
            fBookList fBL = new fBookList();
            this.Hide();
            fBL.ShowDialog();
            this.Show();
        }

        private void btfUserList_Click(object sender, EventArgs e)
        {
            fUserList fUL = new fUserList();
            this.Hide();
            fUL.ShowDialog();
            this.Show();
        }
        #endregion 

        //#region Method
        //#endregion
        //#region Property
        //#endregion
        //#region Events
        //#endregion


    }
}
