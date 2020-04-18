using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            decimal positive = 0.0m, negative = 0.0m, zero = 0.0m;
            int l = arr.Length;

            for (int i = 0; i < l; i++)
            {
                if (arr[i] == 0)
                {
                    zero++;
                }
                else if (arr[i] > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            decimal positiveresult = positive / l;
            Console.WriteLine("Positive : {0}",Math.Round(positiveresult, 6));

            decimal negativeresult = negative / l;
            Console.WriteLine("Negative : {0}",Math.Round(negativeresult, 6));

            decimal zeroresult = zero / l;
            Console.WriteLine("Zero : {0}",Math.Round(zeroresult, 6));
        }
    }
}
