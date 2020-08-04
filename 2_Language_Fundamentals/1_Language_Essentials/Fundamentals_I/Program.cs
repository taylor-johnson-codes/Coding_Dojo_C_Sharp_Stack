using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255

            Console.WriteLine("For loop 1-255:");
            for (int i = 1; i <= 255; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("While loop 1-255:");
            int num = 1;
            while (num <= 255)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

            Console.WriteLine("Loop 1-100; values divisible by 3 or 5 (not both):");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and 
            // "FizzBuzz" for numbers that are multiples of both 3 and 5

            Console.WriteLine("Fizz Buzz version:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
            }
        }
    }
}
