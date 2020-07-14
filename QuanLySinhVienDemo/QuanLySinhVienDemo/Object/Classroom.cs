using System.Collections.Generic;

namespace QuanLySinhVienDemo.Object
{
    public class Classroom
    {
        public string codeClass { set; get; }
        public string nameClass { set; get; }

        public List<Student> listStudent { set; get; }

        public Classroom(string codeClass, string nameClass, List<Student> listStudent)
        {
            this.codeClass = codeClass;
            this.nameClass = nameClass;

            this.listStudent = listStudent;
        }

        public override string ToString()
        {
            return codeClass + " - " + nameClass;
        }
    }
}