using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string binary = Convert.ToString(Int32.Parse(n), 2);
            char[] output = new char[binary.Length];

            for (int i = 1; i < binary.Length+1; i++)
            {
                output[output.Length- i] = binary[i-1];
            }
            string o = new string(output);
            int x = Convert.ToInt32(o, 2);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
