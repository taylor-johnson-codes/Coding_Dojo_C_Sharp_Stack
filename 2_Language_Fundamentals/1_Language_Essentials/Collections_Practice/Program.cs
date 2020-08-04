using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THREE BASIC ARRAYS");

            // Create an array to hold integer values 0 through 9
            int[] myArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(myArray);

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] namesArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(namesArray);

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[] {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(boolArray);


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LIST OF FLAVORS");

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>() {"chocolate", "vanilla", "mint", "cookie dough", "peanut butter"};
            Console.WriteLine(flavors);

            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);

            // Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.Remove("mint");

            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("USER INFO DICTIONARY");

            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
            //    each key is a name from your names array
            //    each value is a randomly select a flavor from your flavors list.

            Random random = new Random();
            int index0 = random.Next(flavors.Count);
            int index1 = random.Next(flavors.Count);
            int index2 = random.Next(flavors.Count);
            int index3 = random.Next(flavors.Count);
            Dictionary<string, string> flavorDict = new Dictionary<string, string>() 
            {
                {namesArray[0], flavors[index0]},
                {namesArray[1], flavors[index1]},
                {namesArray[2], flavors[index2]},
                {namesArray[3], flavors[index3]},
            };

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string,string> item in flavorDict)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
