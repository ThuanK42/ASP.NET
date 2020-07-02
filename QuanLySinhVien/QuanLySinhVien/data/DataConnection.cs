using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.data
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            // neu dung window authencation
            conStr = "Data Source =  DESKTOP-JAOQ4A2\\SQLEXPRESS; Initial Catalog = QuanLySinhVien; Integrated Security = true";
           /* neu co username va password
            * conStr = "Data Source =  DESKTOP-JAOQ4A2\\SQLEXPRESS; Initial Catalog = QuanLySinhVien; UID = sa;PWD = 23031998";*/
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(conStr);
        }
    }
}
