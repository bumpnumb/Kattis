using System;
using System.Collections.Generic;

namespace mountainbiking
{
    //https://open.kattis.com/problems/mountainbiking

    class Slope
    {
        public int Length;
        public int Angle;

        public Slope(int length, int angle)
        {
            Length = length;
            Angle = angle;
        }
    }
    class Program
    {
        public static float ConvertToRadians(float angle)
        {
            return ((float)Math.PI / 180) * angle;
        }
        static void Main()
        {

            string text = Console.ReadLine();
            int nInputs = Int32.Parse(text.Split(' ')[0]);
            float g = float.Parse(text.Split(' ')[1]);

            List<Slope> Slopes = new List<Slope>();

            int length;
            int angle;

            for (int i = 0; i < nInputs; i++)
            {
                text = Console.ReadLine();

                length = Int32.Parse(text.Split(' ')[0]);
                angle = Int32.Parse(text.Split(' ')[1]);

                Slope s = new Slope(length, angle);
                Slopes.Add(s);
            }

            float velocity = 0;

            List<float> velocityFinal = new List<float>();

            for (int i = Slopes.Count - 1; i >= 0; i--)
            {
                // FinalVelocity = InitialVelocity + 2 * a * d
                // a = g * cos(angle)
                velocity = velocity + 2 * g * MathF.Cos(ConvertToRadians(Slopes[i].Angle)) * Slopes[i].Length;

                velocityFinal.Add(velocity);
            }

            for (int i = velocityFinal.Count - 1; i >= 0; i--)
            {
                // recursively print to save memory?
                Console.WriteLine(Math.Sqrt(velocityFinal[i]).ToString());
            }
        }
    }
}
