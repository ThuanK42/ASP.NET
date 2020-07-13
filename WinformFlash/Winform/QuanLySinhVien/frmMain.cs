using QuanLySinhVien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
        SinhVien SelectedSinhVien = null;


        private void frmMain_Load(object sender, EventArgs e)
        {
            FakeData();
            HienThiDuLieuLenTreeView();
            HienThiKhoaLenCombobox();
        }

        private void HienThiDuLieuLenTreeView()
        {
            tvKhoa.Nodes.Clear();

            foreach(KeyValuePair<string,Khoa> itemKhoa in CSDL)
            {
                Khoa kh = itemKhoa.Value;
                TreeNode nodeKhoa = new TreeNode(kh.TenKhoa);
                nodeKhoa.Tag = kh;
                tvKhoa.Nodes.Add(nodeKhoa);

                foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
                {
                    LopHoc lp = itemLop.Value;
                    TreeNode nodeLop = new TreeNode(lp.TenLop);
                    nodeLop.Tag = lp;
                    nodeKhoa.Nodes.Add(nodeLop);
                }
            }

            tvKhoa.ExpandAll();
         
        }

        private void FakeData()
        {
            Khoa cntt = new Khoa() 
            { MaKhoa="CNTT",TenKhoa = "Khoa Công nghệ thông tin"};
            Khoa kt = new Khoa()
            { MaKhoa = "KT", TenKhoa = "Khoa Kinh tế" };
            Khoa ck = new Khoa()
            { MaKhoa = "CK", TenKhoa = "Khoa Cơ khí" };
            Khoa cnty = new Khoa()
            { MaKhoa = "CNTY", TenKhoa = "Khoa Chăn nuôi thú y" };
            Khoa ln = new Khoa()
            { MaKhoa = "LN", TenKhoa = "Khoa Lâm nghiệp" };

            CSDL.Add(cntt.MaKhoa,cntt);
            CSDL.Add(kt.MaKhoa, kt);
            CSDL.Add(ck.MaKhoa, ck);
            CSDL.Add(cnty.MaKhoa, cnty);
            CSDL.Add(ln.MaKhoa, ln);


            LopHoc lopcntt1 = new LopHoc() { MaLop="cntt1",TenLop="Đại học tin học 1"};
            cntt.Lops.Add(lopcntt1.MaLop, lopcntt1);
            lopcntt1.KhoaChuQuan = cntt;
            LopHoc lopcntt2 = new LopHoc() { MaLop = "cntt2", TenLop = "Đại học tin học 2" };
            cntt.Lops.Add(lopcntt2.MaLop, lopcntt2);
            lopcntt2.KhoaChuQuan = cntt;

            LopHoc lopkt1 = new LopHoc() { MaLop = "kinhte1", TenLop = "Đại học Kinh tế 1" };
            kt.Lops.Add(lopkt1.MaLop, lopkt1);
            lopkt1.KhoaChuQuan = kt;
            LopHoc lopkt2 = new LopHoc() { MaLop = "kinhte2", TenLop = "Đại học Kinh tế 2" };
            kt.Lops.Add(lopkt2.MaLop, lopkt2);
            lopkt2.KhoaChuQuan = kt;

            SinhVien sv1 = new SinhVien() { 
                Ma = "sv1", 
                Ten="Le Van Thuan",
                GioiTinh=false,
                NamSinh = new DateTime(1998,03,23)};
            lopcntt1.SinhViens.Add(sv1.Ma, sv1);
            sv1.LopChuQuan = lopcntt1;

            SinhVien sv2 = new SinhVien()
            {
                Ma = "sv2",
                Ten = "Nguyen Van Quang",
                GioiTinh = false,
                NamSinh = new DateTime(1998, 07, 07)
            };
            lopcntt1.SinhViens.Add(sv2.Ma, sv2);
            sv2.LopChuQuan = lopcntt1;

            SinhVien sv3 = new SinhVien()
            {
                Ma = "sv3",
                Ten = "Tran Viet Son",
                GioiTinh = false,
                NamSinh = new DateTime(1998, 05, 19)
            };
            lopcntt1.SinhViens.Add(sv3.Ma, sv3);
            sv3.LopChuQuan = lopcntt1;

        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node != null)// có chọn nút gì đó trên giao diện
            {
                if (e.Node.Level == 1)// đúng là NSD chọn nút lớp học => hiển thị dssv
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    HienThiDanhSachSinhVienTheoLop(lp);
                }
                else
                {
                    lvSinhVien.Items.Clear();// xóa đi vì ko xem dssv
                }
            }
        }

        private void HienThiDanhSachSinhVienTheoLop(LopHoc lp)
        {
            lvSinhVien.Items.Clear();
            foreach (KeyValuePair<string,SinhVien> itemSinhVien in lp.SinhViens)
            {
                SinhVien sv = itemSinhVien.Value;
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.GioiTinh == false? "Nam":"Nữ");
                if(sv.NamSinh != null) 
                    lvi.SubItems.Add(sv.NamSinh.ToString("dd/MM/yyyy"));
                else
                    lvi.SubItems.Add(sv.NamSinh.ToString("<.....>"));
                lvSinhVien.Items.Add(lvi);
                lvi.Tag = sv;
                
            }
        }

        private void HienThiKhoaLenCombobox()
        {
            cboKhoa.Items.Clear();
            foreach (KeyValuePair<string, Khoa> itemKhoa in CSDL)
            {
                Khoa kh = itemKhoa.Value;
                cboKhoa.Items.Add(kh);
            }
        }

        private void HienThiLopLenCombobox(Khoa kh)
        {
            cboLop.Items.Clear();
            foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
            {
                LopHoc lp = itemLop.Value;
                cboLop.Items.Add(lp);
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex == -1) return;
            Khoa kh = cboKhoa.SelectedItem as Khoa;
            HienThiLopLenCombobox(kh);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa");
                return;
            }

            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn lớp");
                return;
            }

            SinhVien sv = new SinhVien();
            sv.Ma = txtMa.Text;
            sv.Ten = txtTen.Text;
            sv.GioiTinh = radNu.Checked;
            LopHoc lp = cboLop.SelectedItem as LopHoc;
            sv.LopChuQuan = lp;
            lp.SinhViens.Add(sv.Ma, sv);

            MessageBox.Show("Đã lưu thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xu ly xoa
            if(SelectedSinhVien != null)
            {
                LopHoc lp = SelectedSinhVien.LopChuQuan;
                lp.SinhViens.Remove(SelectedSinhVien.Ma);
                MessageBox.Show("Đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để xóa");
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSinhVien.SelectedItems[0];
            SinhVien sv = lvi.Tag as SinhVien;

            txtMa.Text = sv.Ma;
            txtTen.Text = sv.Ten;

            if (sv.GioiTinh) radNu.Checked = true;
            else radNam.Checked = true;
            SelectedSinhVien = sv;

            
        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Thoat !", 
                "Hoi thoat", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();// Application.Exit();
        }

        private void mnuHeThongLuuDuLieu_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool kt = FileFactory.SaveFile(CSDL, saveFileDialog1.FileName);
                if (kt)
                    MessageBox.Show("Luu tap tin thanh cong");
            }
        }

        private void mnuHeThongDocDuLieu_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CSDL = FileFactory.ReadFile(openFileDialog1.FileName);
                HienThiDuLieuLenTreeView();
            }
        }
    }
}
