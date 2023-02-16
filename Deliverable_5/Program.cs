// Author: Abdiel Parrilla
// Date: 02/16/2023
// Description: Array Sum
using System;

namespace Deliverable_5

{
    class Program
    {
        static int[] RandomArray(int arrayLength)
        {
            Random random = new Random();
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(10, 50);
            }
            return array;
        }

        static int ArraySum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 15: ");
            int arrayLength = 0;
            try
            {
                arrayLength = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
                return;
            }

            if (arrayLength < 5 || arrayLength > 15)
            {
                Console.WriteLine("Invalid input! Please enter an integer between 5 and 15.");
                return;
            }

            int[] array = RandomArray(arrayLength);
            Console.WriteLine("Randomly generated array: ");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            int sum = ArraySum(array);
            Console.WriteLine("Sum of the elements in the array: " + sum);
            Console.ReadLine();
        }
    }
}
