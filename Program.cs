using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        //Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (var i = 1; i <= 255; i++)
            {
                Console.WriteLine($"New NUmber is {i}");
            }
        }

        //Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"New odd number is {i}");
                }

            }
        }

        // Print sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            // Print all of the integers from 1 to 255.
            int sum = 0;
            int i;
            for (i = 0; i <= 255; i++)
            {
                sum += i;

            }
            Console.WriteLine($"New NUmber: {i} Sum:{sum}");
        }

        //Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int i;
            int max = numbers[0];
            for (i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        //Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            int avg = 0;
            for (var idx = 0; idx < numbers.Length; idx++)
            {
                sum += numbers[idx];
                avg = sum / numbers.Length;
            }
            Console.WriteLine($"Average is: {avg}");
        }

        //Array with Odd Numbers
        public static int[] OddArray()
        {
            // Create an array to hold integer values 0 through 9
            //int[] numbers = new int[10]
            int[] numArray = new int[256];
            int j = 0;
            for (var i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    numArray[j] = i;
                    j++;
                }

            }

            /*  for (var i = 1; i < 256; i++)
             {
                 if (i % 2 == 1)
                 {
                     numArray[i] = i;
                 }
             } */

            return numArray;

        }

        //Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            var count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (y < numbers[i])
                {
                    count++;
                }

            }
            return count;
        }


        //Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        //Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for ( var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0 ;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        //Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            var max = numbers[0];
            var avg = 0 ;
            var min = numbers[0];
            var sum = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                sum+=i;
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                avg = sum/numbers.Length;
            }
            Console.WriteLine($"Max: {max} \nMin: {min} \nAverage: {avg}");
        }

        //Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            var j = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                numbers[j] = numbers[i + 1];
                j++;
            }
            numbers[j] = 0;
            foreach (int i in numbers)
                Console.WriteLine(numbers[i]);
        }
        //Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            object[] myArray = new object[numbers.Length];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0){
                    myArray[i] = "Dojo";
                    }
                else
                   myArray[i] = numbers[i]; 
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { -3, -5, -7 };
            int[] arr3 = { 2, 10, -1,3,-2};
            LoopArray(arr1);
            FindMax(arr2);
            GetAverage(arr3);

            int[] myArray = new int[256];
            myArray = OddArray();
            foreach(var i in myArray)
            Console.WriteLine(i);

            SquareArrayValues(arr3);

            int count = GreaterThanY(arr1, 1);
            Console.WriteLine(count);

            object[] myArrayObject = NumToString(arr3);
            foreach(var i in myArrayObject)
            Console.WriteLine(i);

            EliminateNegatives(arr3);
            MinMaxAverage(arr3);
        }

    }
}
