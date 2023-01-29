using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task3
{
    internal class _3abasic
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class _3abasic2 : _3abasic
    {
        public void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Division(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Main()
        {
            int choice;
            _3abasic2 obj = new _3abasic2();
            Console.WriteLine("Enter the two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is:");
            switch (choice)
            {
                case 1:
                    obj.Addition(a, b);
                    break;
                case 2:
                    obj.Subtraction(a, b);
                    break;
                case 3:
                    obj.Multiplication(a, b);
                    break;
                case 4:
                    obj.Division(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }

    }
}
