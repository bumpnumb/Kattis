using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceCup
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int first = Int32.Parse(input.Split(' ')[0]); //6
            int second = Int32.Parse(input.Split(' ')[1]); //6

            if (first >= second)
            {
                for (int i = 1; i <= first+1 - second; i++) //7, 
                {
                    Console.WriteLine(second + i);
                }
            }
            else
            {
                for (int i = 1; i <= second+1 - first; i++)
                {
                    Console.WriteLine(first + i);
                }
            }
            Console.ReadKey();
        }
    }
}
