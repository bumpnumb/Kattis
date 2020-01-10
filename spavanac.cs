using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();


            int h = Int32.Parse(a.Split(' ')[0]);
            int m = Int32.Parse(a.Split(' ')[1]);

            if (m - 45 < 0)
            {
                m = m + 60 - 45;
                if (h - 1 < 0)
                {
                    h = 23;
                }
                else
                    h--;
            }
            else
                m -= 45;

            Console.WriteLine("{0} {1}", h, m);
        }

    }
}
