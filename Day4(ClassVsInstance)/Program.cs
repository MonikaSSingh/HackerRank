using System;

namespace Day4_ClassVsInstance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number's of people want to check the age ");
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("Enter Age");
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }

        public class Person
        {
            public int age;
            public Person(int initialAge)
            {
                // Add some more code to run some checks on initialAge
                if (initialAge > 0)
                {
                    age = initialAge;
                }
                else
                {
                    Console.WriteLine("Age is Not valid. setting age to 0.");
                    age = 0;
                }
            }
            public void amIOld()
            {
                // Do some computations in here and print out the correct statement to the console 
                if (age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else
                {
                    if (age >= 13 && age < 18)
                    {
                        Console.WriteLine("You are a teenager");
                    }
                    else
                    {
                        Console.WriteLine("You are old.");
                    }
                }

            }
            public void yearPasses()
            {
                // Increment the age of the person in here
                age += 1;
            }
        }
    }
}
