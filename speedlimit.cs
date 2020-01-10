using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    class Program
    {
        public static class Values
        {
            public static int Miles { get; set; }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {


                int n = Int32.Parse(Console.ReadLine());
                if (n.ToString() == "-1") break;
                string input;
                int[] speed = new int[n];
                int[] time = new int[n];

                for (int j = 0; j < n; j++)
                {
                    input = Console.ReadLine();
                    speed[j] = Int32.Parse(input.Split(' ')[0]);
                    time[j] = Int32.Parse(input.Split(' ')[1]);

                    if (j > 0)
                    {
                        Values.Miles += speed[j] * (time[j] - time[j - 1]);
                    }
                    else
                    {
                        Values.Miles += speed[j] * time[j];
                    }
                }
                Console.WriteLine(Values.Miles + " Miles");
                Values.Miles = 0;
            }
        }
    }
}
