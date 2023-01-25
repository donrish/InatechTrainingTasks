using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task4
{
    public abstract class Arith
    {
        public abstract void amds();
    }
    public class Add : Arith
    {
        public override void amds()
        {
            Console.WriteLine("Enter the 2 numbers to add");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is:");
            Console.WriteLine(value1 + value2);
        }
        public class Sub : Arith
        {
            public override void amds()
            {
                Console.WriteLine("Enter the 2 numbers to subtract");
                int value1 = Convert.ToInt32(Console.ReadLine());
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The answer is:");
                Console.WriteLine(value1 - value2);
            }
        }
        public class Mul : Arith
        {
            public override void amds()
            {
                Console.WriteLine("Enter the 2 numbers to multiply");
                long value1 = Convert.ToInt64(Console.ReadLine());
                long value2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("The answer is:");
                Console.WriteLine(value1 * value2);
            }
        }
        public class Div : Arith
        {
            public override void amds()
            {
                Console.WriteLine("Enter the 2 numbers to divide");
                long value1 = Convert.ToInt64(Console.ReadLine());
                long value2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("The answer is:");
                Console.WriteLine(value1 / value2);
            }
        }
        public class Calculator
        {
            public static void Main(string[] args)
            {
                Add obj = new Add();
                obj.amds();
                Sub obj1 = new Sub();
                obj1.amds();
                Mul obj2 = new Mul();
                obj2.amds();
                Div obj3 = new Div();
                obj3.amds();

            }
        }
    }
}