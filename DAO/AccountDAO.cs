using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoQuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool LoginAdmin(string userName, string passWord)
        {
            string sql = "SELECT * FROM dbo.Account WHERE UserName = N'Admin' AND PassWord = N'123' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(sql);

            return result.Rows.Count > 0;
        }
        public bool LoginGuest(string userName, string passWord)
        {
            string sql = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(sql);

            return result.Rows.Count > 0;
        }

    }
}
