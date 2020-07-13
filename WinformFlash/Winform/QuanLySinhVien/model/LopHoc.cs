using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    public class LopHoc
    {
        public string MaLop { set; get; }
        public string TenLop { set; get; }

        public string GiaoVienCoVan { set; get; }

        public Dictionary <string,SinhVien> SinhViens { set; get; }

        public LopHoc() {
            SinhViens = new Dictionary<string, SinhVien>(); 
        }

        public override string ToString()
        {
            return TenLop;
        }

        public Khoa KhoaChuQuan { set; get; }
    }
}
