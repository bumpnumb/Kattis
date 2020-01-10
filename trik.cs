using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trik
{
    class Program
    {
        public static class Values
        {
            public static string Current { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char char1;
            Values.Current = "1";

            for (int i = 0; i < input.Length; i++)
            {
                char1 = input[i];

                switch (char1) //ex: AB, BC
                {
                    case ('A'):
                        if (Values.Current == "1") Values.Current = "2";
                        else if (Values.Current == "2") Values.Current = "1";

                        break;
                    case ('B'):
                        if (Values.Current == "2") Values.Current = "3";
                        else if (Values.Current == "3") Values.Current = "2";
                        break;
                    case ('C'):
                        if (Values.Current == "3") Values.Current = "1";
                        else if (Values.Current == "1") Values.Current = "3";
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(Values.Current);

            Console.ReadKey();

        }
    }
}
