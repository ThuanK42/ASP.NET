using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializble
{
    public class FileFactory
    {
        public static bool LuuFile(List<SinhVien> dsSV, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsSV);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<SinhVien> DocFile(string path)
        {
            List<SinhVien> dsSV = new List<SinhVien>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                dsSV = data as List<SinhVien>;
                fs.Close();
                return dsSV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
