using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task1
{
    internal class task1b
    {
        public static void Main(string[] args)
        {
            string rep;
            Console.WriteLine("Do you have a travel history? yes or no");
            rep = Console.ReadLine();
            if (rep == "yes")
            {
                Console.WriteLine("Do you have temperature? yes or no");
                rep = Console.ReadLine();
                if (rep == "yes")
                {
                    Console.WriteLine("Do you have cough or sneeze? yes or no");
                    rep = Console.ReadLine();
                    if (rep == "yes")
                    {
                        Console.WriteLine("Take a Swab test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine and take medicine");
                    }
                }
                else
                {
                    Console.WriteLine("Home Quarantine for 28 days");
                }

            }
            else
            {
                Console.WriteLine("Safe, No COVID19");
            }
        }
    }
}

