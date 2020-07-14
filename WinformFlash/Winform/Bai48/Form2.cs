using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai48
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<DanhMuc> tuVi = new List<DanhMuc>();

        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc TuPhuVuTuong = new DanhMuc();
            TuPhuVuTuong.Ma = "TPVT";
            TuPhuVuTuong.Ten = "Tử Phủ Vũ Tướng";
            tuVi.Add(TuPhuVuTuong);

            SanPham spTuVi = new SanPham();
            spTuVi.Ma = "TuVi";
            spTuVi.Ten = "Tử Vi";
            spTuVi.Gia = 2000;
            TuPhuVuTuong.ThemSanPham(spTuVi);

            SanPham spThienPhu = new SanPham();
            spThienPhu.Ma = "ThienPhu";
            spThienPhu.Ten = "Thiên Phủ";
            spThienPhu.Gia = 1700;
            TuPhuVuTuong.ThemSanPham(spThienPhu);

            SanPham spVuKhuc = new SanPham();
            spVuKhuc.Ma = "VuKhuc";
            spVuKhuc.Ten = "Vũ Khúc";
            spVuKhuc.Gia = 1600;
            TuPhuVuTuong.ThemSanPham(spVuKhuc);

            SanPham spThienTuong = new SanPham();
            spThienTuong.Ma = "ThienTuong";
            spThienTuong.Ten = "Thiên Tướng";
            spThienTuong.Gia = 1600;
            TuPhuVuTuong.ThemSanPham(spThienTuong);

            DanhMuc SatPhaTham = new DanhMuc();
            SatPhaTham.Ma = "SPT";
            SatPhaTham.Ten = "Sát Phá Tham";
            tuVi.Add(SatPhaTham);

            SanPham spThatSat = new SanPham();
            spThatSat.Ma = "ThatSat";
            spThatSat.Ten = "Thất Sát";
            spThatSat.Gia = 1800;
            SatPhaTham.ThemSanPham(spThatSat);

            SanPham spPhaQuan = new SanPham();
            spPhaQuan.Ma = "PhaQuan";
            spPhaQuan.Ten = "Phá Quân";
            spPhaQuan.Gia = 1800;
            SatPhaTham.ThemSanPham(spPhaQuan);

            SanPham spThamLang = new SanPham();
            spThamLang.Ma = "ThamLang";
            spThamLang.Ten = "Tham Lang";
            spThamLang.Gia = 1800;
            SatPhaTham.ThemSanPham(spThamLang);

            foreach (DanhMuc dm in tuVi)
            {
                // tao nhom cho listview
                ListViewGroup lvg = new ListViewGroup(dm.Ten);
                listView1.Groups.Add(lvg);

                foreach(SanPham sp in dm.SanPhams)
                {
                    // tao 1 dong listview item
                    ListViewItem lvi = new ListViewItem(sp.Ma);
                    lvi.SubItems.Add(sp.Ten);
                    lvi.SubItems.Add(sp.Gia + "");
                    lvi.Group = lvg;

                    listView1.Items.Add(lvi);

                    if (dm == TuPhuVuTuong) lvi.ForeColor = Color.Red;
                }
            }

        }

    }
}
