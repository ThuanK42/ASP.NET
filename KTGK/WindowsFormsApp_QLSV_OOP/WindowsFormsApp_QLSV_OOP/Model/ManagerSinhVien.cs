using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_QLSV_OOP.Model
{
    class ManagerSinhVien
    {
        public List<SinhVien> getListSinhvien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            SinhVien sv1 = new SinhVien();
            sv1.MaSV = "100";
            sv1.TenSV = "Hau";
            sv1.Diachi = "Tay Ninh2";
            sv1.Email = "itvietnam1998@gmail.com";
            listSinhVien.Add(sv1);

            SinhVien sv2 = new SinhVien();
            sv2.MaSV = "101";
            sv2.TenSV = "Hau1";
            sv2.Diachi = "Tay Ninh1";
            sv2.Email = "itvietnam1998@gmail.com";
            listSinhVien.Add(sv2);

            SinhVien sv3 = new SinhVien();
            sv3.MaSV = "102";
            sv3.TenSV = "Hau2";
            sv3.Diachi = "Tay Ninh3";
            sv3.Email = "itvietnam1998@gmail.com";
            listSinhVien.Add(sv3);

            return listSinhVien;

        }
    }
}
