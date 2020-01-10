using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPrintedStatues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int days = 1;
            int printers = 1;

            while (printers < n)
            {
                days += 1;
                printers *= 2;
            }

            Console.WriteLine(days);
            Console.ReadKey();
        }
    }
}
