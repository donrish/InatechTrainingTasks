using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task3
{
    internal class Userlogin3c
    {
        string email = "don123@gmail.com";
        string password = "don@123";
        int pin = 5555;
        int pin_num = 5555;
        string Mid = "Don123";
        long mb = 7878787878;
        public void validate(string p1, string p2)
        {
            email = p1;
            password = p2;
            if (p1 == email && p2 == password)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(string p1, int p2)
        {
            Mid = p1;
            pin = p2;
            if (p1 == Mid && p2 == pin)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public void validate(long p1, int p2)
        {
            mb = p1;
            pin_num = p2;
            if (p1 == mb && p2 == pin_num)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }
        public static void Main(string[] args)
        {
            Userlogin3c obj = new Userlogin3c();
            Console.WriteLine("Enter Login Credentials:");
            Console.Write("a.Login with Email id and password\t");
            Console.Write("b.Login with Membership id and pin\t");
            Console.WriteLine("c.Login with Mobile no and pin\t");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "a":
                    Console.WriteLine("Enter Email id:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string pass = Console.ReadLine();
                    obj.validate(email, pass);
                    break;
                case "b":
                    Console.WriteLine("Enter Membership id:");
                    string Mid = Console.ReadLine();
                    Console.WriteLine("Enter pin:");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    obj.validate(Mid, pin);
                    break;
                case "c":
                    Console.WriteLine("Enter mobile number:");
                    long mb = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter pin:");
                    int pin_num = Convert.ToInt32(Console.ReadLine());
                    obj.validate(mb, pin_num);
                    break;
                default:
                    break;
            }

        }
    }
}

