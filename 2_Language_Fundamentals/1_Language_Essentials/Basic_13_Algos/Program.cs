using System;
using System.Collections.Generic;

namespace Basic_13_Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            PrintOdds();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            PrintSum();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            int[] myNumbers = new int[] {1,2,3,4,5};
            LoopArray(myNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Max number is: " + FindMax(myNumbers));
            int[] negNumbers = new int[] {-1,-2,-3,-4,-5};
            Console.WriteLine("Max number is: " + FindMax(negNumbers));

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            GetAverage(myNumbers);
            GetAverage(negNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            int[] myOddArray = OddArray();
            foreach (int item in myOddArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Number of values greater than Y: " + GreaterThanY(myNumbers, 4));
            Console.WriteLine("Number of values greater than Y: " + GreaterThanY(myNumbers, 1));
            Console.WriteLine("Number of values greater than Y: " + GreaterThanY(negNumbers, -3));

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");



            Console.WriteLine();
            Console.WriteLine("-------------------------------------");



            Console.WriteLine();
            Console.WriteLine("-------------------------------------");



            Console.WriteLine();
            Console.WriteLine("-------------------------------------");



            Console.WriteLine();
            Console.WriteLine("-------------------------------------");



        }

        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.Write(i + " ");
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                Console.Write(i + " ");
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.Write($"Number: {i}  Sum: {sum}; ");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The average is: " + sum/numbers.Length);
        }

        public static int[] OddArray()
        {
            int[] oddArray = new int[128];
            int count = 0;
                for (int i = 1; i <= 255; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddArray[count] = i;
                        count++;
                    }
                }
            return oddArray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
// // #8 Square the Values
// // Square each value in a given array, returning that same array with changed values. 

// function squareArrayVals(arr){
//     for (var i = 0; i < arr.length; i++) {
//         arr[i] = arr[i] * arr[i]
//     }
//     return arr
// }
// console.log(squareArrayVals([1,2,3,4,5]))



// // #10 Zero Out Negative Numbers
// // Return the given array, after setting any negative values to zero. 

// function zeroOut(arr){
//     for (var i = 0; i < arr.length; i++) {
//         if(arr[i] < 0){
//             arr[i] = 0
//         }
//     }
//     return arr
// }
// console.log(zeroOut([-2,-1,0,1,2]))


// // #11 Max, Min, Average
// // Given an array, print the max, min and average values for that array.

// function MaxMinAvg(arr){
//     var max = arr[0]
//     var min = arr[0]
//     var sum = 0
//     for (var i = 0; i < arr.length; i++) {
//         if(arr[i] > max){
//             max = arr[i]
//         }
//         if(arr[i] < min){
//             min = arr[i]
//         }
//         sum += arr[i]
//     }
//     console.log(max, min, sum/arr.length)
// }
// MaxMinAvg([1,2,3,4,5])


// // #12 Shift Array Values
// // Given an array, move all values forward (to the left) by one index, dropping the first value and leaving a 0 (zero) value at the end of the array.

// function shiftArrLeft(arr){
//     for (var i = 0; i < arr.length; i++) {
//         arr[i] = arr[i+1]
//     }
//     arr[arr.length-1] = 0
//     console.log(arr)
// }
// shiftArrLeft([1,2,3,4,5])


// // #13 Swap String For Array Negative Values
// // Given an array of numbers, replace any negative values with the string 'Dojo'.

// function swapString(arr){
//     for (var i = 0; i < arr.length; i++) {
//         if(arr[i] < 0){
//             arr[i] = "Dojo"
//         }
//     }
//     console.log(arr)
// }
// swapString([-2,-1,0,1,2])