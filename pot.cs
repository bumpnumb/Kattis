using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int x = (Int32.Parse(Console.ReadLine()));
                total += (int)(Math.Round((Math.Pow(x / 10, x % 10))));
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
