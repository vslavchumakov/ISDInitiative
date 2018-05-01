using System;
using System.Collections.Generic;


namespace Task_3
{
    #region Hometask_08_3
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create a class called MyDictionary <TKey, TValue>. 
    // Implement in the simplest approximation the possibility of using its instance. 
    // The minimum required interaction interface with the instance must include the method of adding pairs of elements,
    // an indexer to retrieve the value of the element at the specified index, 
    // and a read-only property to obtain the total number of pairs of elements.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Create Empty Dictionary
            MyDictionary<int, string> testDictionary = new MyDictionary<int, string>();
            
            // Method Add works 
            testDictionary.Add(0, "Zero");
            testDictionary.Add(1, "One");
            testDictionary.Add(2, "Two");
            
            for (int i = 0; i < testDictionary.Count+1; i++) // Property Count work
            {
                Console.Write(testDictionary[i]+"\n"); // An indexer works
                // go beyond the borders (i= testDictionary.Count+1) to show Exception
            }

            // Delay
            Console.ReadKey();
        }
    }
}
