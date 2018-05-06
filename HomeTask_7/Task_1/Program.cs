using System;
using System.Linq;

namespace Task_1
{
    #region Hometask_07_1
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create an anonymous method that takes three integer arguments as arguments 
    // and returns the arithmetic mean of these arguments.
    //
    #endregion
    class Program
    {
        /// <summary>
        /// Method which clears last line on the Console
        /// </summary>
        static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <param name="message">Message for user</param>
        /// <returns>Integer number</returns>
        static int InputNumber(string message)
        {
            string enter = null;
            int number = 0;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                Console.Write(message);
                enter = Console.ReadLine();
            } while (!int.TryParse(enter, out number));
            return number;
        }
        
        // Declares a delegate for a method that takes in 3 integers and returns a double.
        private delegate double Mydelegate(int x, int y, int z); 

        static void Main(string[] args)
        {

            Mydelegate average = delegate (int a, int b, int c)
            {
                int[] numbers = { a, b, c };
                return numbers.Average();
            };

            int x = InputNumber("Enter first number: ");
            int y = InputNumber("Enter second number: ");
            int z = InputNumber("Enter third number: ");

            // Display the result of a called method associated with a delegate
            Console.WriteLine("Average =  {0:##.###}", average(x, y, z)); 
            // Delay
            Console.ReadKey();
        }
    }
}
