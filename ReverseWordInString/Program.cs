using System;
using System.Linq;

namespace ReverseWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string you want to reverse word : ");
            string inputString = Console.ReadLine();

            string result = string.Join(" ", inputString
                .Split(' ')
                .Select(a => new string(a.Reverse().ToArray())));

            Console.WriteLine("\n {0}",result);
            Console.ReadLine();
        }
    }
}
