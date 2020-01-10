using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktor
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = Console.ReadLine();

            Console.WriteLine(Int32.Parse(x.Split(' ')[0]) * Int32.Parse(x.Split(' ')[1]) - (Int32.Parse(x.Split(' ')[0]) - 1));
            Console.ReadKey();
        }
    }
}
