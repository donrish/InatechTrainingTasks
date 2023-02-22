using KoreDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreDbFirst
{
    internal class Program
    {
        public static void Insertdept()
        {
            using (var dbcon = new DivscContext())
            {
                Dept d = new Dept();
                d.DepartmentName = "Management";
                dbcon.Add(d);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void Insertemp()
        {
            using(var dbcon = new DivscContext())
            {
                Employee emp = new Employee();
                emp.Employeename = "Ram";
                emp.Empgender= "F";
                dbcon.Add(emp);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void Main(string[] args)
        {
            //Insertdept();
            Insertemp();
            Console.WriteLine("success");
        }
    }
}
