using System;
using System.Collections;

namespace Task_1
{
    #region Hometask_09_1
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create a method that takes an array of integers as an argument and
    // returns a collection of all even numbers of the array.
    // To generate a collection, use the yield statement.
    //
    #endregion

    class Program
    {
        /// <summary>
        /// A static method that takes as an argument an array of integers and returns values ​​of type IEnumerable
        /// </summary>
        /// <param name="array"></param>
        /// <returns>IEnumerable</returns>
        static IEnumerable FindEven(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                    if (array[i] % 2 == 0)
                        // The yield operator is the operator of code generation for collection
                        yield return array[i];
            }
            else yield break;
        }

        static void Main(string[] args)
        {
            int count = 15;
            Random rnd = new Random();
            // Creates array of 15 random integer numbers
            int[] testArray = new int[count];
            for (int i = 0; i < testArray.Length; i++) testArray[i] = rnd.Next(101);

            // Displays array
            Console.WriteLine("Array of 15 integer numbers:");
            foreach (int item in testArray)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            // In the evenResult variable of the IEnumerable type,
            // write the result of the FindEven
            IEnumerable evenResult = FindEven(testArray);

            // Displays collection of even numbers
            Console.WriteLine("Even numbers:");
            foreach (int even in evenResult)
            {
                Console.Write(even + "\t");
            }
            Console.WriteLine();

            // Delay
            Console.ReadKey();
        }
    }
}
