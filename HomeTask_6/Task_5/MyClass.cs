using System;

namespace Task_5
{
    static class MyClass
    {
        /// <summary>
        /// Method which displays the string with the specified color
        /// </summary>
        /// <param name="line"></param>
        /// <param name="color"></param>
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.WriteLine("Default color of line");
                    break;
            }
            // Displays line on Console
            Console.WriteLine(line);
        }
    }
}
