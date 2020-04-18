using System;

namespace FIZZBUZZ
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[15];
            string a = "hello hi juno";
            string[] aa = a.Split(" ");
            
            foreach (var item in aa)
            {
                int ab= item.Length;
                Console.WriteLine(ab);
            }
           


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (arr[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (arr[i] % 3 != 0 && arr[i] % 5 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    Console.WriteLine("FIZZBUZZ");
                }
            }
        }
    }
}
