using System;

namespace drmmessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string t1 = text.Substring(0, text.Length / 2);
            string t2 = text.Substring(text.Length / 2, text.Length / 2);

            int[] output = new int[text.Length / 2];


            int rot1 = 0;
            int rot2 = 0;
            for (int i = 0; i < text.Length / 2; i++)
            {
                rot1 += t1[i] - 'A';
                rot2 += t2[i] - 'A';
            }

            for (int i = 0; i < text.Length / 2; i++)
            {
                int a = t1[i] - 'A';
                a += rot1;
                a = a % ('Z' - 'A' + 1);

                int b = t2[i] - 'A';
                b += rot2;
                b = b % ('Z' - 'A' + 1);

                output[i] = (a + b) % ('Z' - 'A' + 1) + 'A';
            }

            foreach (int i in output)
            {
                Console.Write((char)i);
            }
            Console.Write("\r\n");
        }
    }
}
