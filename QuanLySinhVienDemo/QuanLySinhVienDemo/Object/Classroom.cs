using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDemo.Object
{
    public class Classroom
    {
        public int codeClass { set; get; }
        public string nameClass { set; get; }

        public int codeTeacher { set; get; }

        public List<Student> listStudent;

        public Classroom(int codeClass, string nameClass, int codeTeacher)
        {
            this.codeClass = codeClass;
            this.nameClass = nameClass;
            this.codeTeacher = codeTeacher;
            listStudent = new List<Student>();
        }

        public override string ToString()
        {
            return codeClass + " - " + nameClass+" - "+codeTeacher;
        }

    }
}
