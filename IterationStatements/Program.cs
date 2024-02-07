using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            // Initialize num variable with 0
            int num = 0;

            // Do-while loop to add numbers from 1 to 100 to the list
            do
            {
                num++; // Increment num by 1
                numbers.Add(num); // Add num to the numbers list
            } while (num < 100); // Continue while num is less than 100

            // While loop to add numbers from 101 to 200 to the list
            while (num < 200)
            {
                num++; // Increment num by 1
                numbers.Add(num); // Add num to the numbers list
            }

            Console.WriteLine("Increase:");

            // Foreach loop to print each number in the numbers list in increasing order
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // For loop to print the numbers in reverse order, from 200 to 1
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
