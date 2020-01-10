using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string output = "";

            string[] words = x.Split('-');

            foreach (string word in words)
            {
                output += word[0];
            }
            Console.WriteLine(output);

        }
    }
}
