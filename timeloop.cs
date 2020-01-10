using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}