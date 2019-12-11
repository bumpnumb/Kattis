using System;

namespace railroad2
{
    class Program
    {
        static void Main()
        {
            string x = Console.ReadLine();
            int b = Int32.Parse(x.Split(' ')[1]);
            
            if(b%2 == 0)
                Console.WriteLine("possible");
            else
                Console.WriteLine("impossible");
        }
    }
}