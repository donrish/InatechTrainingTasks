using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task2
{
    internal class mul2b
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                int num = i * n;
                Console.WriteLine("{0}*{1}={2}", n, i, num);
            }
        }
    }
}
