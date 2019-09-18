using System;
using System.Collections.Generic;

namespace grid
{
    //https://open.kattis.com/problems/grid

    class Node
    {
        public int Value;
        public int Cost;
        public int X;
        public int Y;

        public Node(int val, int x, int y)
        {
            Value = val;
            Cost = 999999999;
            X = x;
            Y = y;
        }
    }

    class Program
    {

        public static Node GetBestNode(List<Node> queue, int goalX, int goalY)
        {
            Node best = queue[0];
            foreach (Node n in queue)
            {
                if (n.Cost > best.Cost)
                    best = n;
            }
            return best;
        }
        public static int Expander(Node[][] arr, int goalX, int goalY)
        {
            List<Node> queue = new List<Node>();
            queue.Add(arr[0][0]);
            Node current;
            while (queue.Count > 0)
            {
                current = queue[queue.Count-1];
                queue.RemoveAt(queue.Count - 1);

                //Print(arr, current.X, current.Y, current.Cost);

                if (current.X + current.Value <= arr[1].Length - 1)
                {
                    if (arr[current.Y][current.X + current.Value].Cost > current.Cost + 1)
                    {
                        arr[current.Y][current.X + current.Value].Cost = current.Cost + 1;
                        queue.Add(arr[current.Y][current.X + current.Value]);
                    }
                }

                if (current.X - current.Value >= 0)
                {
                    if (arr[current.Y][current.X - current.Value].Cost > current.Cost + 1)
                    {
                        arr[current.Y][current.X - current.Value].Cost = current.Cost + 1;
                        queue.Add(arr[current.Y][current.X - current.Value]);
                    }
                }

                if (current.Y + current.Value <= arr.Length - 1)
                {
                    if (arr[current.Y + current.Value][current.X].Cost > current.Cost + 1)
                    {
                        arr[current.Y + current.Value][current.X].Cost = current.Cost + 1;
                        queue.Add(arr[current.Y + current.Value][current.X]);
                    }
                }

                if (current.Y - current.Value >= 0)
                {
                    if (arr[current.Y - current.Value][current.X].Cost > current.Cost + 1)
                    {
                        arr[current.Y - current.Value][current.X].Cost = current.Cost + 1;
                        queue.Add(arr[current.Y - current.Value][current.X]);
                    }
                }

            }

            if (arr[goalY][goalX].Cost == 999999999)
                return -1;

            return arr[goalY][goalX].Cost;
        }


        static void Main()
        {
            string text = Console.ReadLine();
            int y = Int32.Parse(text.Split(' ')[0]);
            int x = Int32.Parse(text.Split(' ')[1]);

            Node[][] arr = new Node[y][];

            for (int i = 0; i < y; i++)
            {
                arr[i] = new Node[x];

                text = Console.ReadLine();
                for (int j = 0; j < x; j++)
                {
                    arr[i][j] = new Node(Int32.Parse(text[j].ToString()), j, i);
                }
            }
            List<Node> first = new List<Node>();
            arr[0][0].Cost = 0;
            first.Add(arr[0][0]);
            Console.WriteLine(Expander(arr, x - 1, y - 1));
        }
    }
}
