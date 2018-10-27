using DemoQuanLyThuVien.DAO;
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
    public partial class fBookList : Form
    {
        public fBookList()
        {
            InitializeComponent();

        }

        private void fBookList_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Book";
            dtgvfBookList.DataSource = DataProvider.Instance.ExecuteQuery(sql);
            AddBookBinding();
        }

        void AddBookBinding()
        {
            txtBookListName.DataBindings.Add(new Binding("Text", dtgvfBookList.DataSource, "name"));
        }
        void  LoadCategoryBookIntoCombobox(ComboBox cb)
        {
           // cb.DataSource = BookDAO.Instance.
        }

    }
}
