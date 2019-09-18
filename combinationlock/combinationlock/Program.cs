using System;

namespace combinationlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "0 0 0 0")
            {
                int start = Int32.Parse(line.Split(' ')[0]);
                int a = Int32.Parse(line.Split(' ')[1]);
                int b = Int32.Parse(line.Split(' ')[2]);
                int c = Int32.Parse(line.Split(' ')[3]);
                Console.WriteLine("" + (120 + (start - a + 40) % 40 + (b - a + 40) % 40 + (b - c + 40) % 40) * 9);
            }
        }
    }
}
