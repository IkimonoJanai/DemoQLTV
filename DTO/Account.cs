using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQuanLyThuVien
{
    class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }
        public string Type { get; set; }

        public Account(string UserName, string DisplayName, string PassWord, string Type)
        {
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.PassWord = PassWord;
            this.Type = Type;
        }
    }
}
