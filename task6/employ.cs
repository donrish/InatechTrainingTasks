using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tasks
{
    internal class employ
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empgender { get; set; }
        public int Empage { get; set; }
        public void readfEmp()
        {
            FileStream emp = new FileStream("D:\\INATECH\\inatech app\\mango.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(emp);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }
        public static void Main(string[] args)
        {
            employ emp = new employ();
            Console.WriteLine("Enter the employee name:");
            emp.Empname = Console.ReadLine();
            Console.WriteLine("Enter the employee gender:");
            emp.Empgender = Console.ReadLine();
            Console.WriteLine("Enter the employee ID:");
            emp.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee age:");
            emp.Empage = Convert.ToInt32(Console.ReadLine());

            FileStream Emp = new FileStream("D:\\INATECH\\inatech app\\mango.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Emp);
            sw.Write(emp.Empname);
            sw.Write(emp.Empgender);
            sw.Write(emp.Empage);
            sw.Write(emp.Empid);
            sw.Flush();
            sw.Close();
            Emp.Close();
            emp.readfEmp();
        }
    }
}
