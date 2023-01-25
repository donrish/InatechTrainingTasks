using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task2
{
    internal class Display
    {
        public static void Main()
        {
            string name;
            int age;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= age; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}