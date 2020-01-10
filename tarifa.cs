using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthly, n, total;

            monthly = Int32.Parse(Console.ReadLine());
            n = Int32.Parse(Console.ReadLine());


            total = 0;
            for (int i = 0; i < n; i++)
            {
                total += monthly;
                total -= Int32.Parse(Console.ReadLine());
                if (total < 0)
                    total = 0;
            }
            total += monthly;

            Console.WriteLine(total);
        }
    }
}
