using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Tasks
{
    internal class employee
    {

        double salary, bonus;

        public void Sales(double n)
        {
            this.salary = n;
            double bonus = (salary * 20) / 100;
            double total = salary + bonus;
            Console.WriteLine("Employee salary is:{0}", salary);
            Console.WriteLine("Employee bonus is:{0}", bonus);
            Console.WriteLine("Total salary of employee is:{0}", total);

        }

        public void Production(double n)
        {
            this.salary = n;
            double bonus = (salary * 10) / 100;
            double total = bonus + salary;
            Console.WriteLine("Employee salary is:{0}", salary);
            Console.WriteLine("Employee bonus is:{0}", bonus);
            Console.WriteLine("Total salary of employee is:{0}", total);
        }
    }
    class Emp : employee
    {
        public static void Main(string[] args)
        {
            employee obj = new employee();
            Console.WriteLine("Enter the eID:");
            int Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter the years of experience:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary in two digit precision:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your department:");
            Console.WriteLine("1.Sales & Marketing Department");
            Console.WriteLine("2.Production Department");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("----------------");
                    Console.WriteLine("Employee ID :{0}", Eid);
                    Console.WriteLine("Name:{0}", name);
                    Console.WriteLine("Gender:{0}", gender);
                    Console.WriteLine("Experience{0}", years);
                    obj.Sales(n);
                    break;

                case 2:
                    Console.WriteLine("----------------");
                    Console.WriteLine("Employee ID :{0}", Eid);
                    Console.WriteLine("Name:{0}", name);
                    Console.WriteLine("Gender:{0}", gender);
                    Console.WriteLine("Experience{0}", years);
                    obj.Production(n);
                    break;
            }

        }

    }
}