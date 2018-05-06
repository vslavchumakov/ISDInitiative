using System;

namespace Task_5
{
    /// <summary>
    /// Enum of colors
    /// </summary>
    enum Colors { Green, Red, Blue }


    #region Hometask_06_5
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create a static class with the void Print method(string stroka, int color), 
    // which displays a string with the specified color.
    // Using the enumeration, create a set of colors available to the user.
    // Enter the line and choose a color for the user.
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
        /// <returns>Integer number</returns>
        static int InputNumber()
        {
            string enter = null;
            int number = 0;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                enter = Console.ReadLine();
            } while (!int.TryParse(enter, out number) || number<0 || number>2);
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string line = Console.ReadLine();

            Console.WriteLine("Choose the color:\n 0 - Green\n 1 - Red\n 2 - Blue ");
            int color = InputNumber();

            // Calls the static Print method
            MyClass.Print(line, color);

            Console.ForegroundColor = ConsoleColor.Black;
            //Delay
            Console.ReadKey();
        }
    }
}
