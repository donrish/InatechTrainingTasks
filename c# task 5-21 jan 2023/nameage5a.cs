using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class nameage5a
    {
        string name;
        int age;
        public nameage5a()
        {
            name = "Ram";
            age = 21;
        }
        public nameage5a(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Using object:");
            nameage5a obj = new nameage5a();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.WriteLine("Using passing paramters:");
            nameage5a obj1 = new nameage5a("Shyam", 22);
            Console.WriteLine(obj1.name);
            Console.WriteLine(obj1.age);
        }

    }
}

