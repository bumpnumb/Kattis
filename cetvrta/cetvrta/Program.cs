using System;
using System.Collections.Generic;
using System.Linq;

namespace cetvrta
{
    class point
    {
        public int x;
        public int y;
        public point(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<point> points = new List<point>();
            string line;
            for (int i = 0; i < 3; i++)
            {
                line = Console.ReadLine();
                point p = new point(Int32.Parse(line.Split(' ')[0]), Int32.Parse(line.Split(' ')[1]));
                points.Add(p);
            }

            int numX = points.GroupBy(p => p.x)
                  .OrderByDescending(g => g.Count())
                  .SelectMany(g => g).Last().x;

            int numY = points.GroupBy(p => p.y)
                  .OrderByDescending(g => g.Count())
                  .SelectMany(g => g).Last().y;

            Console.WriteLine("" + numX + " " + numY);

        }
    }
}
