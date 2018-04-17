using System;
namespace Task_2
{
    class Program
    {

        /// <summary>
        /// Method which clear last line on the Console
        /// </summary>
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Read user input and return double number in right case
        /// </summary>
        /// <returns>double number which >=0</returns>
        static double ReadLength()
        {
            string enter;
            bool isInputRight;
            double length;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                Console.Write("Enter length of rectangle: ");
                enter = Console.ReadLine();
                isInputRight = double.TryParse(enter, out length);
            } while (!isInputRight || length <= 0);
            return length;
        }

        #region Hometask_02_2
        //
        // Author: Shemet Viktoriya
        //
        // Description: 
        // Required: Create a class called Rectangle.
        // In the body of the class, create two fields that describe 
        // the length of the sides of double side1, side2.
        // Create a custom constructor Rectangle(double side1, double side2),
        // in the body of which the side1 and side2 fields are initialized with argument values.
        // Create two methods that calculate the area of the rectangle -
        // double AreaCalculator () and the perimeter of the rectangle - double PerimeterCalculator ().
        // Create double Area and double Perimeter properties with one get method.
        // Write a program that takes from the user the length of the two sides of the rectangle
        // and displays the perimeter and area on the screen.
        //
        #endregion

        static void Main(string[] args)
        {
            double side1, side2;    // first and second length of the sides
            side1 = ReadLength();
            side2 = ReadLength();
            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Area of rectangle = {rect.AreaCalculator()}");
            Console.WriteLine($"Perimeter of rectangle = {rect.PerimeterCalculator()}");
            // Delay
            Console.ReadKey();
        }
    }
}
