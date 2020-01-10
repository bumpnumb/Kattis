using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving4Carrots
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string disgard = Console.ReadLine();
            disgard = Console.ReadLine();
            Console.WriteLine(value.Split(' ')[1]);
            Console.ReadKey();
        }
    }
}
