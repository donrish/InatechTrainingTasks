using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.task3
{
    internal class _3bvatgst
    {
        class vatgst3b
        {
            public void Calculatetax()
            {
                double vat = 0.2;
                double price = 100;
                double tax = price * vat;
                Console.WriteLine("VAT is:" + tax + "%");
            }
        }
        class gstvat : vatgst3b
        {
            public new void Calculatetax()
            {
                double gst = 0.12;
                double price = 100;
                double tax = price * gst;
                Console.WriteLine("GST is:" + tax + "%");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                vatgst3b vobj = new vatgst3b();
                vobj.Calculatetax();
                gstvat dobj = new gstvat();
                dobj.Calculatetax();
            }
        }
    }
}
