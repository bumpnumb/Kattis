using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckenMirko
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double n, c;
            n = Int32.Parse(input.Split(' ')[0]);
            c = Math.Sqrt((Math.Pow(Int32.Parse(input.Split(' ')[1]), 2)) + Math.Pow(Int32.Parse(input.Split(' ')[2]), 2));

            for (int i = 0; i < n; i++)
            {
                if (Int32.Parse(Console.ReadLine()) > c)
                    Console.WriteLine("NE");
                else Console.WriteLine("DA");
            }
            Console.ReadKey();

        }
    }
}
