using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap11
{
    class Student
    {
        public string name;
        public string msv;
        public string className;
        public Student()
        {
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setMSV(string msv)
        {
            this.msv = msv;
        }
        public void setClassName(string className)
        {
            this.className = className;
        }
        public string getName()
        {
            return this.name;
        }
        public string getMSV()
        {
            return this.msv;
        }
        public string getClassName()
        {
            return this.className;
        }
    }
    
    
    class Classes
    {
        public string name { get; set; }
        public string nameSchool { get; set; }
        public  List<Student> listSV { get; set; }
        public Classes(string name,string nameSchool)
        {
            this.name = name;
            this.nameSchool = nameSchool;
            listSV = new List<Student>();
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        List<Classes> listClass;

        public Program()
        {
            Classes c1 = new Classes("DH16DTB", "Đại học Nông lâm");
            Classes c2 = new Classes("DH16DTA", "Đại học Nông lâm");
            Classes c3 = new Classes("DH16DTC", "Đại học Nông lâm");

            Student sv1 = new Student(); sv1.setName("Võ Văn Kiệt"); sv1.setMSV("456465"); sv1.setClassName(c1.name);
            c1.listSV.Add(sv1);
            Student sv2 = new Student(); sv2.setName("Huỳnh Thị Như Ý"); sv2.setMSV("45645"); sv2.setClassName(c2.name);
            c1.listSV.Add(sv2);

            //set up Class
            listClass = new List<Classes>();
    
            listClass.Add(c1);
            listClass.Add(c2);
            listClass.Add(c3);


        }
        public void addClass()
        {
            Console.Write("Tên class : ");
            string name = Console.ReadLine();
            Console.Write("Tên trường : ");
            string school = Console.ReadLine();
            Classes c = new Classes(name, school);
            listClass.Add(c);
            Console.WriteLine("Thêm thành công Enter để quoay lại...");
            Console.ReadLine();
        }
        public void renameClass()
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i + " Lớp : {0} - số lượng sv: {1}", c.name, c.listSV.Count);
            }
            Console.Write("chọn lớp bạn muốn đổi tên : ");
            int idClass = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập tên mới : ");
            string newName = Console.ReadLine();
            listClass[idClass].setName(newName);
            Console.WriteLine("Đổi tên thành công Enter thế tiếp tục thao tác....");
            Console.ReadLine();
        }
        public void removeClass()
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i + " Lớp : {0} - số lượng sv: {1}", c.name, c.listSV.Count);
            }
            Console.WriteLine();
            Console.Write("mời bạn nhập vị trí lớp muốn xóa : ");
            int id = int.Parse(Console.ReadLine());
            if(listClass.Remove(listClass[id]))
            {
                Console.WriteLine("Xóa thành công Enter để tiếp tục tao tác...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Xóa thất bại Enter để tiếp tục thao tác...");
                Console.ReadLine();
            }
        }
        public void addStudent()
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i + " Lớp : {0} - số lượng sv: {1}", c.name, c.listSV.Count);
            }
            Console.Write("Mời bạn chọn lớp cho Sinh viên: ");
            Student sv = new Student();

            int idClass = int.Parse(Console.ReadLine());
            sv.setClassName(listClass[idClass].name);
            Console.Write("Nhập tên Sinh Viên : ");
            sv.setName(Console.ReadLine());
            Console.Write("Nhập mã số Sinh vien: ");
            sv.setMSV(Console.ReadLine());
            listClass[idClass].listSV.Add(sv);
            Console.WriteLine("Đã thêm Sinh viên thành công Enter để tiếp tục thao tác ....");
            Console.ReadLine();
        }
        public void editStudent()
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i + " Lớp : {0} - số lượng sv: {1}", c.name, c.listSV.Count);
            }
            Console.Write("Sinh Viên thuộc lớp : ");
            int idClass = int.Parse(Console.ReadLine());
            Classes cl = listClass[idClass];
            Console.Clear();

            Console.WriteLine("Lớp " + cl.name + "Số lượng Sinh viên :" + cl.listSV.Count);
            for (int j = 0; j < cl.listSV.Count; j++)
            {
                Student s = cl.listSV[j];
                Console.WriteLine(j + " MSV:{0}- Tên SV: {1}",s.name,s.msv);
            }
            Console.Write("Chọn Sinh viên để thây đổi thông tin : ");
            Student svEdit = cl.listSV[int.Parse(Console.ReadLine())];
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" MSV:{0} - Tên SV: {1} - Lớp :{2}",  svEdit.msv, svEdit.name, svEdit.className);
                Console.WriteLine("1 Thây đổi tên SV");
                Console.WriteLine("2 Thây đổi MSV SV");
                Console.WriteLine("0 Để thoát ra");
                string lenh = Console.ReadLine();
                if (lenh.Equals("0")) break;

                switch (lenh)
                {
                    case "1":
                        Console.Write("Nhập tên mới SV :");
                        svEdit.setName(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Nhập Mã mới cho SV :");
                        svEdit.setMSV(Console.ReadLine());
                        break;
                }
            }
        }
        public void deleteStudent()
        {
            for (int i = 0; i < listClass.Count; i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i + " Lớp : {0} - số lượng sv: {1}", c.name, c.listSV.Count);
            }
            Console.Write("Sinh Viên thuộc lớp : ");
            int idClass = int.Parse(Console.ReadLine());
            Classes cl = listClass[idClass];
            Console.Clear();

            Console.WriteLine("Lớp " + cl.name + "Số lượng Sinh viên :" + cl.listSV.Count);
            for (int j = 0; j < cl.listSV.Count; j++)
            {
                Student s = cl.listSV[j];
                Console.WriteLine(j + " MSV:{0}- Tên SV: {1}", s.name, s.msv);
            }
            Console.Write("Chọn Sinh viên muốn xóa : ");
            Student svDelete = cl.listSV[int.Parse(Console.ReadLine())];
            listClass[idClass].listSV.Remove(svDelete);
            Console.WriteLine("Xóa thành công Enter để tiếp tục thao tác....");
            Console.ReadLine();
        }
        public void start(string count)
        {
            Console.Clear();
            switch (count)
            {
               case "0" :
                  
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Phần mền quản lý Sinh Viên");
                    Console.WriteLine();
                    Console.WriteLine("1 Thêm mới lớp");
                    Console.WriteLine("2 Đổi tên lớp");
                    Console.WriteLine("3 Xóa lớp");
                    Console.WriteLine("4 In danh sách lớp");
                    Console.WriteLine("5 Thêm Sinh viên");
                    Console.WriteLine("6 Đổi thông tin Sinh viên");
                    Console.WriteLine("7 Xóa sinh viên");

                    break;
                case "1":addClass();
                    break;

                case "2":renameClass();
                    break;

                case "3": removeClass();
                    break;

                case "4": showClass(listClass);
                    break;

                case "5": addStudent();
                    break;

                case "6": editStudent();
                    break;
                case "7":
                    deleteStudent();
                    break;




            }


        }
        public void showClass(List<Classes> listClass)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--Danh sách các lớp hiện của của Trường--");
            for(int i =0;i < listClass.Count;i++)
            {
                Classes c = listClass[i];
                Console.WriteLine(i+ " Lớp : {0} - số lượng sv: {1}", c.name,c.listSV.Count);
            }
            Console.WriteLine("Enter để thoát");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            //set up Class
          
            while (true)
            {
                p.start("0");
                Console.Write("Mới bạn chọn chức năng: ");
                p.start(Console.ReadLine());

            }


        }
    }
}
