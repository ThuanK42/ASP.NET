using QuanLySinhVienDemo.Object;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLySinhVienDemo.Dao
{
    public class UserDao
    {
        public  UserSystem _user = null;

        public UserDao()
        {
            if (!File.Exists("Data\\UserFile.txt"))
            {
                File.Create("Data\\UserFile.txt");
            }
        }

        public bool DangNhap(string username, string password)
        {
            List<UserSystem> lstUserSystem2 = DocFileUser();

            if (lstUserSystem2.Count > 0) // neu list user ko rong
            {
                foreach (UserSystem us in lstUserSystem2)
                {
                    if (us.username.Equals(username) == true && us.password.Equals(password) == true)
                    {
                        _user = new UserSystem(us.username, us.password);

                        return true;
                    }
                }
            }

            return false;
        }

        public bool KiemTraUserDaTonTaiTrongHeThongChua(string username, string pass)
        {

            List<UserSystem> lstUserSystem = DocFileUser();
            if (lstUserSystem.Count > 0)
            {
                foreach (UserSystem us in lstUserSystem)
                {
                    if (us.username.Equals(username) == true && us.password == pass)
                    {
                        return true;
                    }
                    if (us.username.Equals(username) == true)
                    {
                        return true;
                    }
                    if (us.password == pass)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public  bool DangKy(string username, string password)
        {
            if (KiemTraUserDaTonTaiTrongHeThongChua(username, password) == false)
            {
                /*lstUserSystem.Add(new UserSystem(username, password));*/
                LuuFileUser(username, password);

                return true;
            }
            return false;
        }

        public static List<UserSystem> DocFileUser()
        {
            List<UserSystem> lus = new List<UserSystem>();
            try
            {
                StreamReader sr = new StreamReader("Data\\UserFile.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 2)
                    {
                        UserSystem us = new UserSystem();
                        us.username = arr[0];
                        us.password = arr[1];

                        lus.Add(us);
                    }
                    line = sr.ReadLine();// doc dong tiep theo
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lus;
        }

        public static void LuuFileUser(string username, string password)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Data\\UserFile.txt", true, Encoding.UTF8);// ghi de, co dau

                string line = username + ";" + password ;
                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}