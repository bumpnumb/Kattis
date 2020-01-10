using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());


            if (x >= 0)
            {
                if (y >= 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);

                }
            }
            else
            {
                if (y>=0)
                {
                    Console.WriteLine(2);

                }
                else
                {
                    Console.WriteLine(3);

                }
            }

        }
    }
}
