using System;

namespace Day7_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (int i = n - 1; i > -1; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
