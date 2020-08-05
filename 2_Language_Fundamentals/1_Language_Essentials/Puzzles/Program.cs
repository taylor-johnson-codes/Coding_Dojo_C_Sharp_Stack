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

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            
            double returnedRatio = TossMultipleCoins(5);
            Console.WriteLine("Heads to toss ratio: " + returnedRatio);
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            
            List<string> returnedList = Names();
            Console.WriteLine("Names greater than 5: ");
            foreach (string item in returnedList)
            {
                Console.Write(item + " ");
            }
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
            double headsCount = 0;
            for (int i = 1; i <= num; i++)
            {
                string result = TossCoin();
                if (result == "Heads")
                {
                    headsCount++;
                }
            }
            double ratio = headsCount/num;
            return ratio;
        }

        /*
        Build a function Names that returns a list of strings.  In this function:
        - Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        - Shuffle the list and print the values in the new order
        - Return a list that only includes names longer than 5 characters
        */
        public static List<string> Names()
        {
            List<string> nameList = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Console.WriteLine("Original list:");
            foreach (string item in nameList)
            {
                Console.Write(item + " ");
            }
            
            Random random = new Random();
            for (int i = 0; i < nameList.Count; i++)
            {
                int indexNum = random.Next(0, nameList.Count);
                string temp = nameList[indexNum];
                nameList[indexNum] = nameList[i];
            }
            Console.WriteLine();
            Console.WriteLine("Shuffled list:");
            foreach (string item in nameList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            List<string> longerThan5List = new List<string>();
            foreach (string name in nameList)
            {
                if (name.Length > 5)
                {
                    longerThan5List.Add(name);
                }
            }
            return longerThan5List;
        }
    }
}
