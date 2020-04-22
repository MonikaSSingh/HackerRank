using System;

namespace Day6_Let_sReview_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter string");
                string str = Console.ReadLine();
                for (int j = 0; j < str.Length; j++)
                {
                    if (j % 2 == 0) Console.Write(str[j]);
                }
                Console.Write(" ");

                for (int j = 0; j < str.Length; j++)
                {
                    if (j % 2 != 0) Console.Write(str[j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
