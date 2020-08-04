using System;

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

            SquareArrayValues(myNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            EliminateNegatives(negNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            int[] newNumbers = new int[] {-1,0,3,15,100};
            MinMaxAverage(newNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            ShiftValues(newNumbers);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            int[] moreNewNumbers = new int[] {-105,-3,0,15,100};
            object[] returnedArray = NumToString(moreNewNumbers);
            foreach (object item in returnedArray)
            {
                Console.Write(item + " ");
            }
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

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Average: {sum/numbers.Length}");
        }
        
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] objectArray = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    objectArray[i] = "Dojo";
                }
                else
                {
                    objectArray[i] = numbers[i];
                }
            }
            return objectArray;
        }
    }
}