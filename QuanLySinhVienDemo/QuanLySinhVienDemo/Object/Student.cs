namespace QuanLySinhVienDemo.Object
{
    public class Student
    {
        public int codeStudent { set; get; }
        public string nameStudent { set; get; }
        public string genderStudent { set; get; }

        public string address { set; get; }
        public string codeClass { set; get; }

        public Student(string codeClass,int codeStudent, string nameStudent, string genderStudent, string address)
        {
            this.codeStudent = codeStudent;
            this.nameStudent = nameStudent;
            this.genderStudent = genderStudent;
            this.address = address;
            this.codeClass = codeClass;
        }

        public override string ToString()
        {
            return codeStudent + " - " + nameStudent + " - " + genderStudent + " - " + address + " - " + codeClass;
        }
    }
}