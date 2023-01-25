using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task4
{
    public abstract class Mempack
    {
        public abstract void mempacktype();
    }
    public class Silvermembership : Mempack
    {
        public override void mempacktype()
        {
            Console.WriteLine("3 days accomodation at resort");
        }
    }
    public class Goldmembership : Mempack
    {
        public override void mempacktype()
        {
            Console.WriteLine("5 days accomodation at resort and 2 dinners on the house");
        }
    }
    public class Platinummembership : Mempack
    {
        public override void mempacktype()
        {
            Console.WriteLine("7 days accomodation at resort and 5 dinners on the house");
        }
    }
    public class MempackImplementation
    {
        public static void Main(string[] args)
        {
            MempackImplementation m1 = new MempackImplementation();
            string membership_choice;
            Console.WriteLine("Enter the required membership choice from silver,gold and platinum:");
            membership_choice = Console.ReadLine();
            Mempack membership;
            switch (membership_choice)
            {
                case "silver":
                    membership = new Silvermembership();
                    break;
                case "gold":
                    membership = new Goldmembership();
                    break;
                case "platinum":
                    membership = new Platinummembership();
                    break;
                default:
                    Console.WriteLine("Invalid membership package");
                    return;
            }
            membership.mempacktype();
        }
    }
}

