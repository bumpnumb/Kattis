using System;

namespace judgingmoose
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int l = Int32.Parse(line.Split(' ')[0]);
            int r = Int32.Parse(line.Split(' ')[1]);

            if (r == 0 && l == 0)
            {
                Console.WriteLine("Not a moose");
            }
            else if (l == r)
            {
                Console.WriteLine("Even " + l * 2);
            }
            else if (l > r)
            {
                Console.WriteLine("Odd " + l * 2);
            }
            else
            {
                Console.WriteLine("Odd " + r * 2);
            }
        }
    }
}
