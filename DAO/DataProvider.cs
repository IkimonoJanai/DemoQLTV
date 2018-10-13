using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DemoQuanLyThuVien.DAO
{
    public class DataProvider
    {
        private string cnStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DemoQuanLyThuVienAlpha;Integrated Security=True";

        public DataTable ExecuteQuery(string sql)
        {
            DataTable data = new DataTable();

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                cn.Close();
            }
            
            return data;
        }
    }
}
