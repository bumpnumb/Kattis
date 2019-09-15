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
                if (n.Cost < best.Cost)
                    best = n;
            }
            return best;
        }

        public static bool IsGoal(Node node, int goalX, int goalY)
        {
            if (node.X == goalX && node.Y == goalY)
                return true;
            return false;
        }

        public static void Print(Node[][] arr, int X, int Y, int cost)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    if (i == Y && j == X)
                        Console.Write('[' + arr[i][j].Value.ToString() + ']');
                    else
                        Console.Write(' ' + arr[i][j].Value.ToString() + ' ');
                }

                Console.Write("\r\n");
            }
            Console.WriteLine(cost);
        }

        public static int Expander(Node[][] arr, List<Node> queue, int goalX, int goalY)
        {
            if (queue.Count == 0)
                return -1;

            Node current = GetBestNode(queue, goalX, goalY);

            //print(arr, current.X, current.Y, current.Cost);



            queue.Remove(current);

            if (IsGoal(current, goalX, goalY))
                return current.Cost;

            if (current.Value == 0)
            {
                current.Cost = -1;
                return Expander(arr, queue, goalX, goalY);
            }
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
            return Expander(arr, queue, goalX, goalY);
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
            Console.WriteLine(Expander(arr, first, x - 1, y - 1));
        }
    }
}
