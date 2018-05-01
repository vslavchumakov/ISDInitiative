using System;
namespace Task_7
{
    #region Hometask_08_7
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create an ArrayList class.
    // Implement in the simplest approximation the possibility of using its instance 
    // is analogous to the instance of the ArrayList class from the System.Collections namespace.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Create Empty ArrayList
            ArrayList myArrayList = new ArrayList();

            // Method Add works 
            myArrayList.Add(0);
            myArrayList.Add(2.75);
            myArrayList.Add(true);
            myArrayList.Add("One");

            // Property Count works
            Console.WriteLine("ArrayList consists of "+ myArrayList.Count + " element(s)");

            Console.WriteLine("Elements of ArrayList:");
            for (int i = 0; i < myArrayList.Count; i++) // Property Count works
            {
                Console.Write(myArrayList[i] + "\n"); // An indexer works
            }

            // Method Contain works 
            Console.WriteLine($"ArrayList contains \"One\"?  - {myArrayList.Contain("One")}");
            Console.WriteLine($"ArrayList contains 5?  - {myArrayList.Contain(5)}");

            // Method Clear works 
            myArrayList.Clear();
            Console.WriteLine("After cleaning ArrayList consists of " + myArrayList.Count + " element(s)");

            // Go beyond the borders to show Exception
            // Attempt to output a nonexistent item in ArrayList
            Console.Write(myArrayList[0]);

            // Delay
            Console.ReadKey();
        }
    }
}
