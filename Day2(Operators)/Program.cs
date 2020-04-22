using System;

namespace Day2_Operators_
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip;
            double tax;
            tip = meal_cost * tip_percent / 100;
            tax = meal_cost * tax_percent / 100;

            double totalCost = meal_cost + tip + tax;

            Console.WriteLine("Total meal cost is : {0} dollars ",Math.Round(totalCost));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter meal cost");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter tip percent");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tip percent");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
