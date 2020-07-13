using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGhiFileText
{
    public class SinhVien
    {
        public int Ma { set; get; }
        public string Ten { set; get; }
        public DateTime NamSinh { set; get; }

        public override string ToString()
        {
            return Ma + "-" + Ten + "-" +NamSinh.ToString("dd/MM/yyyy");
        }

    }
}
