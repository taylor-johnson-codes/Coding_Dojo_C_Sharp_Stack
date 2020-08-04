using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] returnedArray = RandomArray();
            Console.WriteLine("The random array is: ");
            foreach (int item in returnedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            string outcome = TossCoin();
            Console.WriteLine("The coin toss resulted in: " + outcome);
        }
        
        /*
        Create a function called RandomArray() that returns an integer array
        - Place 10 random integer values between 5-25 into the array
        - Print the min and max values of the array
        - Print the sum of all the values
        */
        public static int[] RandomArray()
        {
            Random random = new Random();
            int[] randomArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomArr[i] = random.Next(5,25);
            }
            int max = randomArr[0];
            int min = randomArr[0];
            int sum = 0;
            for (int i = 0; i < randomArr.Length; i++)
            {
                if (randomArr[i] > max)
                {
                    max = randomArr[i];
                }
                if (randomArr[i] < min)
                {
                    min = randomArr[i];
                }
                sum += randomArr[i];
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
            return randomArr;
        }
        
        /*
        Create a function called TossCoin() that returns a string
        - Have the function print "Tossing a Coin!"
        - Randomize a coin toss with a result signaling either side of the coin 
        - Have the function print either "Heads" or "Tails"
        - Finally, return the result
        */
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random random = new Random();
            int toss = random.Next(1,3);
            string result = "";
            if (toss == 1)
            {
                result = "Heads";
            }
            if (toss == 2)
            {
                result = "Tails";
            }
            return result;
        }

        /*
        Create another function called TossMultipleCoins(int num) that returns a Double
        - Have the function call the tossCoin function multiple times based on num value
        - Have the function return a Double that reflects the ratio of head toss to total toss
        */
        public static double TossMultipleCoins(int num)
        {
            
        }
    }
}
