using QuanLySinhVienDemo.Object;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLySinhVienDemo.Dao
{
    public class UserDao
    {
        public UserSystem us = null;
        public string pathFile = "Data\\UserFile.txt";
        public List<UserSystem> lstUserSystem = null;

        public UserDao()
        {
            if (!File.Exists(pathFile)) File.Create(pathFile);
            lstUserSystem = new List<UserSystem>();
        }

        public void DangKy(string username, string password, int codeTeacher)
        {
            lstUserSystem.Add(new UserSystem(username, password, codeTeacher));
            LuuFileUser(lstUserSystem);

        }

        public void DangNhap(string username, string password, int codeTeacher)
        {
            lstUserSystem.Add(new UserSystem(username, password, codeTeacher));
            LuuFileUser(lstUserSystem);

        }

        public static List<UserSystem> DocFileUser()
        {
            List<UserSystem> lstUserSystem = new List<UserSystem>();
            try
            {
                StreamReader sr = new StreamReader("Data\\UserFile.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 3)
                    {
                        UserSystem us = new UserSystem();
                        us.username = arr[0];
                        us.password = arr[1];
                        us.codeTeacher = int.Parse(arr[2]);
                        lstUserSystem.Add(us);
                    }
                    line = sr.ReadLine();// doc dong tiep theo
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstUserSystem;
        }

        public static void LuuFileUser(List<UserSystem> dsUS)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Data\\UserFile.txt", false, Encoding.UTF8);// ghi de, co dau
                foreach (UserSystem us in dsUS)
                {
                    string line = us.username + ";" + us.password + ";" + us.codeTeacher;
                    sw.WriteLine(line);
                }
                sw.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}