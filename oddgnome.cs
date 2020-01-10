using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Gnome
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());
            string temp;
            string[] num;
            int prev, next, current;
            for (int i = 0; i < n; i++)
            {
                temp = Console.ReadLine();

                num = temp.Split(' ');
                current = Int32.Parse(num[1]);
                prev = 0;
                for (int j = 2; j < Int32.Parse(num[0]); j++)
                {
                    prev = Int32.Parse(num[j - 1]);
                    current = Int32.Parse(num[j]);
                    next = Int32.Parse(num[j + 1]);

                    if (next < current && next < prev)
                    {
                        Console.WriteLine(j +1 );
                        break;
                    }
                    else if (next < current && next > prev)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                    else if (prev > current)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}
