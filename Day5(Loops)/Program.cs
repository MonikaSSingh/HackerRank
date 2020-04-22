using System;

namespace Day5_Loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input");

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.Write("\n {0} x {1} = {2} ", n, i, result);
            }
            Console.ReadLine();
        }
    }
}
