using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planina
{
    class Program
    {
        static void Main(string[] args)
        {

            // since 1sec cpu time we can do pretty much whatever with n max = 15
            // looping through each iteration:
            // every node in width and expanding with 1
            // printing squared end width


            int n = Int32.Parse(Console.ReadLine());
            int width = 2;

            for (int i = 0; i < n; i++)
            {
                int temp = 0;
                for (int j = 1; j < width; j++)
                {
                    temp++;
                }
                width += temp;

            }

            Console.WriteLine(width* width);

        }
    }
}
