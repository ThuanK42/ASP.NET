using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    [Serializable]
    public class SinhVien
    {
        public string Ma { set; get; }
        public string Ten { set; get; }
        public DateTime NamSinh { set; get; }

        public bool GioiTinh { set; get; }

        public LopHoc LopChuQuan { set; get; }

        public override string ToString()
        {
            return Ten;
        }
    }
}
