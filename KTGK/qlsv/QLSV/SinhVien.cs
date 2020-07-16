using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SinhVien
    {
        public string tensinhvien { set; get; }
        public string namsinh { set; get; }
        public string gioitinh { set; get; }
        public string monhoc { set; get; }
        public string sothich { set; get; }
        public string ghichu { set; get; }

        public SinhVien()
        {
            tensinhvien = "A";
            namsinh = "25/1/1998";
            gioitinh = "nam";
            monhoc = "Toán";
            sothich = "Đi chơi";
            ghichu = "OK";
        }
        public SinhVien(string tensinhvien,string namsinh,string gioitinh,string monhoc,string sothich,string ghichu)
        {
            this.tensinhvien = tensinhvien;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.monhoc = monhoc;
            this.sothich = sothich;
            this.ghichu = ghichu;

        }
        
    }
}
