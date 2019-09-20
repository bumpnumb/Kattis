using System;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int posX, posY, goalX, goalY;
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                posX = "ABCDEFGH".IndexOf((temp.Split(' ')[0]));
                posY = Int32.Parse(temp.Split(' ')[1]) - 1;
                goalX = "ABCDEFGH".IndexOf((temp.Split(' ')[2]));
                goalY = Int32.Parse(temp.Split(' ')[3]) - 1;

                Console.WriteLine("position = " + posX + " " + posY);
                //posX = i % 8;
                //posY = i / 8;

                //if (i % 8 == 0)
                //    Console.Write("\r\n");

                if (posX % 2 == 0 && posY % 2 != 0 || posX % 2 != 0 && posY % 2 == 0)
                {
                    Console.Write('X');


                }
                else
                {
                    Console.Write('O');
                }



            }
        }
    }
}
