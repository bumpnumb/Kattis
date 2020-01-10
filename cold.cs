using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdputerScience
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int days = 0;
            string input = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                int a = Int32.Parse(input.Split(' ')[i]);
                if (a < 0) days++;
            }
            Console.WriteLine(days);
            Console.ReadLine();
        }
    }
}
