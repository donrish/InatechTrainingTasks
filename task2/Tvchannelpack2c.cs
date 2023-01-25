using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task2
{
    internal class Tvchannelpack2c
    {
        public static void Main()
        {
            string package;
            Console.WriteLine("Package A contains: South special,Children's club,Movies");
            Console.WriteLine("Package B contains: News,sports,movies,regional");
            Console.WriteLine("Package C contains: Discovery,history,national");
            Console.WriteLine("Enter your required package:");
            package = Console.ReadLine();
            switch (package)
            {
                case "A":
                    Console.WriteLine("Rs 250");
                    break;
                case "B":
                    Console.WriteLine("Rs 450");
                    break;
                case "C":
                    Console.WriteLine("Rs 350");
                    break;
                default:
                    Console.WriteLine("Enter the package you need");
                    break;
            }
        }
    }
}
