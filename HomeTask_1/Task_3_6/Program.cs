#region Hometask_01_3_6
//
// Author: Shemet Viktoriya
// Description: Create 5 random integer numbers,
// calculate their average value and inform the user.
//
#endregion
using System;
using System.Linq;
namespace Task_3_6
{
    class Program
    {
        /// <summary>
        /// Create random numbers in Array, between 0 and 100
        /// </summary>
        /// <param name="array"></param>
        static void CreateRandomNumbers(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
        }

        /// <summary>
        /// Display elements of 1-dimension array
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("Array:");
            foreach (int item in array)
            {
                Console.Write(item + "\t");
            }
        }

        /// <summary>
        /// Calculate average of elements of array
        /// </summary>
        /// <param name="array"></param>
        static double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        static void Main(string[] args)
        {
            int[] randomArray = new int[5]; ;
            CreateRandomNumbers(randomArray);
            DisplayArray(randomArray);
            Console.WriteLine($"\nAverage of elements = {CalculateAverage(randomArray)}");
            Console.ReadKey();
        }
    }
}
