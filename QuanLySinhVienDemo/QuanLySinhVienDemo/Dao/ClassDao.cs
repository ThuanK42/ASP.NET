using QuanLySinhVienDemo.Object;
using System.Collections.Generic;

namespace QuanLySinhVienDemo.Dao
{
    public class ClassDao
    {

        public static List<Student> lstStudentA = new List<Student>() {
        new Student("CNTT A", "16130606","Le Van Thuan","Nam","Nha Trang"),
        new Student("CNTT A", "16130607","Le Van Quang","Nam","Nha Trang"),
        new Student("CNTT A", "16130608","Le Van Hieu","Nam","Nha Trang") };

        public static List<Student> lstStudentB = new List<Student>() {
        new Student("CNTT B", "16130609","Le Van Nghia","Nam","Nha Trang"),
        new Student("CNTT B", "16130610","Le Van Nhan","Nam","Nha Trang"),
        new Student("CNTT B", "16130611","Le Van Chi","Nam","Nha Trang") };

        public static List<Student> lstStudentC = new List<Student>() {
        new Student("CNTT C", "16130612","Le Van Khoa","Nam","Nha Trang"),
        new Student("CNTT C", "16130613","Le Van Thien","Nam","Nha Trang"),
        new Student("CNTT C", "16130614","Le Van Bao","Nam","Nha Trang")};

        public static List<Classroom> lstClass = new List<Classroom>() {
        new Classroom("CNTT A", "Lop cong nghe thong tin A",lstStudentA),
        new Classroom("CNTT B", "Lop cong nghe thong tin B",lstStudentB),
        new Classroom("CNTT C", "Lop cong nghe thong tin C",lstStudentC)};



        public List<Classroom> LayDanhSachCacLop()
        {
            return lstClass;
        }

        public List<Classroom> ThemLop(Classroom classroom)
        {
            if (KiemTraLopTonTaiKhong(classroom.codeClass) == false)
                lstClass.Add(classroom);
            return lstClass;
        }

        public List<Classroom> CapNhatTenLop(string codeClass, string nameClass2)
        {
            foreach (Classroom cl2 in lstClass)
            {
                if (cl2.codeClass.Equals(codeClass) == true)
                {
                    cl2.nameClass = nameClass2;
                }
            }
            return lstClass;
        }

        public List<Classroom> XoaLop(string codeClass)
        {
            foreach (Classroom cl2 in lstClass)
            {
                if (cl2.codeClass.Equals(codeClass) == true)
                {
                    lstClass.Remove(cl2);
                    break;
                }
            }
            return lstClass;
        }

        public bool KiemTraLopTonTaiKhong(string codeClass)
        {
            foreach (Classroom cl2 in lstClass)
            {
                if (cl2.codeClass.Equals(codeClass) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Student> LayDanhSachSinhVienTheoMaLop(string codeClass2)
        {
            foreach (Classroom cl2 in lstClass)
            {
                if (cl2.codeClass.Equals(codeClass2) == true)
                {
                    return cl2.listStudent;
                }
            }
            return null;
        }
    }

}