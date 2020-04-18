using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 12 } };
            int d1 = 0;
            int d2 = 0;
            int n = ar.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                d1 += ar[i, i];
                d2 += ar[i, n - i - 1];
            }
            Console.WriteLine("Sum {0}, {1}", d1, d2);
            int result = Math.Abs(d1 - d2);
            Console.Write("Diagonal Difference : {0}",result);
        }
    }
}
