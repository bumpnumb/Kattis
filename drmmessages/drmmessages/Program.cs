using System;

namespace drmmessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string t1 = text.Substring(0, text.Length / 2 - 1);
            string t2 = text.Substring(text.Length / 2 - 1, text.Length - 1);

            foreach (char c in t1)
            {

            }


        }
    }
}
