using System;
using System.Collections.Generic;

namespace whatdoesthefoxsay
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1
            //toot woof wa ow ow ow pa blub blub pa toot pa blub pa pa ow pow toot
            //dog goes woof
            //fish goes blub
            //elephant goes toot
            //seal goes ow
            //what does the fox say ?

            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<String> words = new List<string>();
                words.AddRange(Console.ReadLine().Split(' '));

                List<string> knownWords = new List<string>();
                string line;
                while ((line = Console.ReadLine()) != "what does the fox say?")
                {
                    knownWords.Add(line.Split(' ')[line.Split(' ').Length - 1]);
                }


                for (int j = words.Count - 1; j >= 0; j--)
                {
                    if (knownWords.Contains(words[j]))
                    {
                        words.RemoveAt(j);
                    }
                }
                Console.WriteLine(String.Join(" ", words));

            }

        }
    }
}
