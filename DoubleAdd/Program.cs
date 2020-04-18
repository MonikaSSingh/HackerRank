using System;

namespace DoubleAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            Console.WriteLine("Enter 2nd value of Integer : ");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd value of double : ");
            double e = Convert.ToDouble(Console.ReadLine());
            string str = Console.ReadLine();

            Console.WriteLine(j+i);
            Console.WriteLine((d+e).ToString("F1"));
            Console.WriteLine(s +" " + str);
            Console.ReadLine();


        }
    }
}
