using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class R2
    {

        static void Main(string[] args) //(input1 + x) = input2*2. 
        {
            string value = Console.ReadLine();
            int[] values = new int[2];
            for (int i = 0; i < value.Split(' ').Length; i++)
            {
                values[i] = Int32.Parse(value.Split(' ')[i]);
            }


            string output = "" + ((values[1] * 2) - values[0]);

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
