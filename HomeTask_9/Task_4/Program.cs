using System;
using System.Collections;

namespace Task_4
{
    #region Hometask_09_4
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create an extension method:
    // public static T[] GetArray<T>(this IEnumerable<T> list) {...}
    // Apply the extension method to an instance of the type MyList<T>, developed in homework 2 for this lesson. 
    // Display the values ​​of the elements of the array that returned the extension method GetArray().
    //
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the MyList class and 
            // initializing by the default constructor
            var list = new MyList<int>();

            // Fills the list with 10 random values
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(51)); // random integers from 0 to 50
            }

            // Displays the values ​​of the elements of the array 
            // that returned the extension method GetArray()
            Console.WriteLine("Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.GetArray()[i]); // Uses the extension method
            }

            // Delay
            Console.ReadKey();
        }
    }
}
