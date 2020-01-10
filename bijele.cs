using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int[] types = new int[6];
            int[] correct = new int[] { 1, 1, 2, 2,2,8};
            for (int i = 0; i < 6; i++)
            {
                types[i] = (correct[i] - Int32.Parse(n.Split(' ')[i]));
                
            }
            Console.WriteLine(String.Join(" ", types.Select(p => p.ToString()).ToArray()));
            Console.ReadKey();
        }
    }
}
