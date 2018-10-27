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

        public bool Login(string userName, string passWord)
        {
            //string sql = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";
            string sql = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql ,new object[] {@userName , @passWord});

            return result.Rows.Count > 0;
        }

        public int LoginUser(string username , string password)
        {
            // not fix yet 
            // tao login cho user va admin rieng
            string sql = "";

            return 0;
        }

    }
}
