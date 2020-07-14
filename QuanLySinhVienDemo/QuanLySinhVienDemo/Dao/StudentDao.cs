using QuanLySinhVienDemo.Object;
using System.Collections.Generic;

namespace QuanLySinhVienDemo.Dao
{
    public class StudentDao
    {
        private List<Student> students = new List<Student>();

        public StudentDao(List<Student> listStudent)
        {
            this.students = listStudent;
        }

        public bool KiemTraSinhVienTonTaiKhong(Student student)
        {
            foreach (Student st in students)
            {
                if (st.codeStudent == student.codeStudent) { return true; }
                    
                   
            }
            return false;
        }

        public List<Student> ThemSinhVien(Student student)
        {
            if (KiemTraSinhVienTonTaiKhong(student) == false)
            {
                students.Add(student);
            }
            return students;
        }

        public List<Student> CapNhatThongTinSinhVien(Student student)
        {
            foreach (Student st in students)
            {
                if (st.codeStudent.Equals(student.codeStudent) == true)
                {
                    st.nameStudent = student.nameStudent;
                    st.genderStudent = student.genderStudent;
                    st.address = student.address;
                }
            }
            return students;
        }

        public void XoaSinhVien(string codeStudent)
        {
            foreach (Student st in students)
            {
                if (st.codeStudent.Equals(codeStudent) == true)
                {
                    students.Remove(st);
                    break;
                }
            }
           
        }

        public List<Student> LayDanhSachSinhVien()
        {
            return students;
        }
    }
}