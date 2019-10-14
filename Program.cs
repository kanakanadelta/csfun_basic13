using System;

namespace BasicThirteen
{
    class Program
    {
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            Console.WriteLine("Print 1-255");
            for(int i = 1; i <= 255; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n Print 1-255 END");
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            Console.WriteLine("Print Odds");
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("\n Print Odds END");
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            Console.WriteLine("Print Sum");
            int sum = 0;
            for(int i = 1; i <= 255; i++)
            {
                sum+=i;
                Console.Write($"/* New Number: {i}, sum: {sum}*/ ,");
            }
                Console.WriteLine("\n Print Sum END");
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            Console.WriteLine("LoopArray");
            Console.Write("[");
            for(int i = 0; i < numbers.Length; i++) 
            {
                // print each value to the console. 
                if(i == numbers.Length-1)
                {
                    Console.Write($"{numbers[i]}");
                }
                else {
                    Console.Write($"{numbers[i]}, ");
                }
            }
            Console.Write("]");
            Console.WriteLine("\n Loop Array End");
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            if(numbers.Length < 0)
            {
                return -1;
            }
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++) 
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"FindMax Result {max}");
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            if(numbers.Length < 0)
            {
                return;
            }
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) 
            {
                sum+=numbers[i];
            }
            Console.WriteLine($"Get Average Result {sum/numbers.Length}");
            Console.WriteLine();
        }
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] result = new int[255/2+1];
            Console.WriteLine("Odd Array");
            int idx = 0;
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    result[idx] = i;
                    Console.Write(result[idx]);
                    idx++;
                }
            }
            Console.WriteLine("\n Odd array END");
            return result;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            if(numbers.Length < 1)
            {
                return -1;
            }
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i]>y)
                {
                    count++;
                }
            }
            return count;
        }
        // // // //
        // MAIN //
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(new int[]{1,2,3,4,5});
            FindMax(new int[]{1, -3, 4, 2});
            GetAverage(new int[]{5,6,7,8,9,10});
            OddArray();
        }
    }
}
