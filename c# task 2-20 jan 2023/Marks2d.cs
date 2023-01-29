using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task2
{
    internal class Marks2d
    {
        public static void Main()
        {
            float[] marks = new float[5];
            float sum = 0;
            Console.WriteLine("Enter the subject marks:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }
            Console.WriteLine("Total marks:");
            Console.WriteLine(sum);
            float percentage = sum / 500 * 100;
            Console.WriteLine("Percentage of marks:");
            Console.WriteLine(percentage);
        }
    }
}

