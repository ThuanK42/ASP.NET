using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_QLSV_OOP.Model
{
    class SinhVien
    {
        private string maSV;
        private string tenSV;
        private string email;
        private string diachi;

        public SinhVien()
        {
           
        }
       

        public SinhVien(string maSV, string tenSV, string email, string diachi)
        {
            MaSV = maSV;
            TenSV = tenSV;
            Email = email;
            Diachi = diachi;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string Email { get => email; set => email = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
