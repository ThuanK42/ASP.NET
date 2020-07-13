using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDemo.Object
{
    public class UserSystem
    {
        public string username { set; get; }
        public string password { set; get; }
        public int codeTeacher { set; get; }

        public UserSystem(string username, string password, int codeTeacher)
        {
            this.username = username;
            this.password = password;
            this.codeTeacher = codeTeacher;
        }

        public UserSystem()
        {

        }

        public override string ToString()
        {
            return username + " - " + password+" - "+codeTeacher;
        }
    }
}
