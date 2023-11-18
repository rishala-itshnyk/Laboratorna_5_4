using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("(iter) S0 = " + S0(N));
            Console.WriteLine("(rec up ++) S1 = " + S1(N, 1));
            Console.WriteLine("(rec up --) S2 = " + S2(N, N));
            Console.WriteLine("(rec down ++) S3 = " + S3(N, 1, 0));
            Console.WriteLine("(rec down --) S4 = " + S4(N, N, 0));
        }

        public static double S0(int N)
        {
            double s = 0;
            for (int k = 1; k <= N; k++)
            {
                s += 1.0 / Math.Pow(2 * k + 1, 2);
            }

            return s;
        }

        public static double S1(int N, int k)
        {
            if (k > N)
            {
                return 0;
            }
            else
            {
                return 1.0 / Math.Pow(2 * k + 1, 2) + S1(N, k + 1);
            }
        }

        public static double S2(int N, int k)
        {
            if (k < 1)
            {
                return 0;
            }
            else
            {
                return 1.0 / Math.Pow(2 * k + 1, 2) + S2(N, k - 1);
            }
        }

        public static double S3(int N, int k, double t)
        {
            t += 1.0 / Math.Pow(2 * k + 1, 2);
            if (k >= N)
            {
                return t;
            }
            else
            {
                return S3(N, k + 1, t);
            }
        }

        public static double S4(int N, int k, double t)
        {
            t += 1.0 / Math.Pow(2 * k + 1, 2);
            if (k <= 1)
            {
                return t;
            }
            else
            {
                return S4(N, k - 1, t);
            }
        }
    }
}