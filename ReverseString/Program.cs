using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the String : ");

            string str = Console.ReadLine();

            int len = str.Length;

            string reverse = "";

            for (int i = len-1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Console.WriteLine("\n The Reverse String is : {0} ",reverse.ToUpper());
            Console.ReadLine();
            
        }
    }
}
