using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai48
{
   public class DanhMuc
    {
        public string Ma { set; get; }
        public string Ten { set; get; }
        public List<SanPham> SanPhams { set; get; }

        public DanhMuc()
        {
            SanPhams = new List<SanPham>();
        }

        public void ThemSanPham(SanPham sp)
        {
            SanPhams.Add(sp);
            sp.Nhom = this;
        }
    }
}
