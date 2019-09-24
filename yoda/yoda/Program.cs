using System;
using System.Collections.Generic;

namespace yoda
{
    class Program
    {

        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        static void Main(string[] args)
        {
            string ina = Console.ReadLine();
            string inb = Console.ReadLine();

            if (ina == "")
            {
                Console.WriteLine("YODA");
                Console.WriteLine(inb);
                return;
            }
            else if (inb == "")
            {
                Console.WriteLine(ina);
                Console.WriteLine("YODA");
                return;
            }


            List<char> a = new List<char>(ina.ToCharArray());
            List<char> b = new List<char>(inb.ToCharArray());

            List<char> resulta = new List<char>();
            List<char> resultb = new List<char>();

            a.Reverse();
            b.Reverse();
            int n = Max(a.Count, b.Count);
            for (int i = 0; i < n; i++)
            {
                if (i < a.Count && i < b.Count)
                {
                    if (a[i] > b[i])
                    {
                        resulta.Add(a[i]);
                    }
                    else if (a[i] < b[i])
                    {
                        resultb.Add(b[i]);
                    }
                    else
                    {
                        resulta.Add(a[i]);
                        resultb.Add(b[i]);
                    }
                }
                else if (i > a.Count && i < b.Count)
                {
                    resultb.Add(b[i]);
                }
                else
                {
                    resulta.Add(a[i]);

                }
            }
            resulta.Reverse();
            resultb.Reverse();

            if (resulta.Count == 0)
                Console.WriteLine("YODA");
            else Console.WriteLine(Int32.Parse(String.Join(String.Empty, resulta)));


            if (resultb.Count == 0)
                Console.WriteLine("YODA");
            else Console.WriteLine(Int32.Parse(String.Join(String.Empty, resultb)));
        }
    }
}
