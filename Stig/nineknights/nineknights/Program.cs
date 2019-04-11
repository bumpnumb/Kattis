using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineknights
{

    public class move
    {
        //These will be ina list of moves for each knight, just a x & y is enough
        public int X { get; set; }
        public int Y { get; set; }
    }


    public class knight
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public move[] moves = new move[8];
        
        public void addMoves()
        {
            //mc to fix null errors......
            int movecounter = 0;
            if (this.posX > 1 && this.posY > 0)
            {
                move llu = new move();
                llu.X = this.posX - 2;
                llu.Y = this.posY - 1;
                this.moves[movecounter] = llu;
                movecounter++;
            }
            if (this.posX > 0 && this.posY > 1)
            {
                move luu = new move();
                luu.X = this.posX - 1;
                luu.Y = this.posY - 2;
                this.moves[movecounter] = luu;
                movecounter++;
            }
            if (this.posX < 4 && this.posY > 1)
            {
                move ruu = new move();
                ruu.X = this.posX + 1;
                ruu.Y = this.posY - 2;
                this.moves[movecounter] = ruu;
                movecounter++;
            }
            if (this.posX < 3 && this.posY > 0)
            {
                move rru = new move();
                rru.X = this.posX + 2;
                rru.Y = this.posY - 1;
                this.moves[movecounter] = rru;
                movecounter++;
            }

            if (this.posX < 3 && this.posY < 4)
            {
                move rrd = new move();
                rrd.X = this.posX + 2;
                rrd.Y = this.posY + 1;
                this.moves[movecounter] = rrd;
                movecounter++;
            }
            if (this.posX < 4 && this.posY < 3)
            {
                move rdd = new move();
                rdd.X = this.posX + 1;
                rdd.Y = this.posY + 2;
                this.moves[movecounter] = rdd;
                movecounter++;
            }
            if (this.posX > 0 && this.posY < 3)
            {
                move ldd = new move();
                ldd.X = this.posX - 1;
                ldd.Y = this.posY + 2;
                this.moves[movecounter] = ldd;
                movecounter++;
            }
            if (this.posX > 1 && this.posY < 4)
            {
                move lld = new move();
                lld.X = this.posX - 2;
                lld.Y = this.posY + 1;
                this.moves[movecounter] = lld;
                movecounter++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            knight[] knig = new knight[25];
            int ht = 0;
            string[] arr = new string[8];


            //loop through each line
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();

                for (int j = 0; j < 5; j++)
                {
                    if (arr[i][j] == 'k')
                    {
                        //if k found add a new knight with a moveset
                        knight k = new knight();
                        k.posX = j;
                        k.posY = i;
                        k.addMoves();
                        knig[ht] = k;
                        ht++;
                        //increament ht counter
                    }
                }
            }

            //if edgecases invalid
            if (ht < 9 || ht > 9)
            {
                Console.WriteLine("invalid");
                System.Environment.Exit(0);
            }

            for (int i = 0; i < ht; i++)
            {
                for (int j = 0; j < knig[i].moves.Length; j++)
                {
                    if (knig[i].moves[j] == null)
                        break;
                    for (int z = 0; z < ht; z++)
                        //for every knights moves, check if any other knight is in that moves pos
                    {
                        if (z == i)
                            continue;
                        else
                        {
                            if (knig[i].moves[j].X == knig[z].posX && knig[i].moves[j].Y == knig[z].posY)
                            {
                                Console.WriteLine("invalid");
                                System.Environment.Exit(0);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("valid");
        }
    }
}
