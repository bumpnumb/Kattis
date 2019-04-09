using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shatteredcake
{
    class Program
    {
        static void Main(string[] args)
        {
            int Width = Int32.Parse(Console.ReadLine());
            int num = Int32.Parse(Console.ReadLine());


            int area = 0;

            for (int i = 0; i < num; i++)
            {
                string temp = Console.ReadLine();

                area += Int32.Parse(temp.Split(' ')[0]) * Int32.Parse(temp.Split(' ')[1]);
            }

            Console.WriteLine(area / Width);

        }
    }
}
