using System;
namespace Task_6
{
    #region Hometask_08_6
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create the class Dictionary <TKey, TValue>. 
    // Implement in the simplest approximation the possibility of using its instance 
    // is analogous to an instance of the Dictionary class from the System.Collections.Generic namespace.
    // The minimum interface required for an instance must include the method of adding element pairs, 
    // an indexer to retrieve the value of the element at the specified index, 
    // and a read-only property to obtain the total number of element pairs.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Create instance MyDictionary for 4 elements 
            var dictionary = new MyDictionary<int, string>(4);

            dictionary.Add(0, 1, "Entry 1");
            dictionary.Add(1, 2, "Entry 2");
            dictionary.Add(2, 3, "Entry 3");
            dictionary.Add(3, 4, "Entry 4");

            // Displays values of dictionary
            for (int i = 0; i < dictionary.Length; i++)
                Console.WriteLine(dictionary[i]);

            Console.WriteLine("The third entry in the dictionary:");
            Console.WriteLine(dictionary[2]); 
          
            // Delay
            Console.ReadKey();
        }
    }
}
