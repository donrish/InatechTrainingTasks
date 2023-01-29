using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task6
{
    internal class Desserts
    {
        public static void Main()
        {
            ArrayList des = new ArrayList();
            des.Add("Rasgulla");
            des.Add("Rasmalai");
            des.Add("Gulab Jamun");
            des.Add("Kajukatli");
            des.Add("Mysorepak");

            FileStream fs = new FileStream("D:\\INATECH\\inatech app\\apple.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in des)
            sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();

            FileInfo info = new FileInfo("D:\\INATECH\\inatech app\\apple.txt");
            Console.WriteLine("Creation Time : {0}",info.CreationTime);
            Console.WriteLine("Size : {0}", info.Length);
        }
    }
}

