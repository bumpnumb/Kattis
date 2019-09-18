using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int iteration = 1;
            while ((line = Console.ReadLine()) != null)
            {
                if (line == "")
                    break;
                int circ = 1 + (int)Math.Floor((Int32.Parse(line) + 1) * Math.Log10(3) - Int32.Parse(line) * Math.Log10(2));
                Console.WriteLine("Case " +  iteration + ": " + circ);
                iteration++;
            }
        }
    }
}
