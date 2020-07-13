using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    public class Khoa
    {
        public string MaKhoa { set; get; }
        public string TenKhoa { set; get; }
        public Dictionary<string,LopHoc> Lops { set; get; }

        public Khoa()
        {
            Lops = new Dictionary<string, LopHoc>();
        }

        public override string ToString()
        {
            return TenKhoa;
        }

    }
}
