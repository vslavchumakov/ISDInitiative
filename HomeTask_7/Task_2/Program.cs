using System;
using System.Text.RegularExpressions;

namespace Task_2
{
    #region Hometask_07_2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create four lambda operators to perform arithmetic operations: 
    // (Add - addition, Sub - subtraction, Mul - multiplication, div - division).
    // Each lambda operator must take two arguments and return the result of the calculation.
    // The lambda division operator must do a division test to zero.
    // Write a program that will perform arithmetic operations specified by the user.
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
        /// <returns>String operation</returns>
        static string InputOperation(string message)
        {
            string operation = null;
            Regex regex = new Regex("[-+*/]");
            Console.WriteLine("");
            do
            {
                ClearLastLine(); // Clear wrong user input
                Console.Write(message);
                operation = Console.ReadLine();
            } while (!regex.IsMatch(operation));
            return operation;
        }

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <param name="message">Message for user</param>
        /// <returns>Double number</returns>
        static double InputNumber(string message)
        {
            string enter = null;
            double number = 0;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                Console.Write(message);
                enter = Console.ReadLine();
            } while (!double.TryParse(enter, out number));
            return number;
        }

        // Declares a delegate for a method that takes in 2 doubles and returns a double.
        delegate double OperationDelegate(double firstNumber, double secondNumber);


        static void Main(string[] args)
        {
            double num1 = InputNumber("Enter first number: ");
            double num2 = InputNumber("Enter second number: ");
            string operation = InputOperation("Enter operation, choose from {+, -, *, /}: ");

            OperationDelegate op = null;
            switch (operation)
            {
                case "+":
                    op = (a, b) => { return a + b; }; // Add
                    break;
                case "-":
                    op = (a, b) => { return a - b; }; // Sub
                    break;
                case "*":
                    op = (a, b) => { return a * b; }; // Mul
                    break;
                case "/":
                    op = (a, b) =>
                    {
                        return b != 0 ? a / b : double.PositiveInfinity; // Div
                    };
                    break;
                default:
                    Console.WriteLine("Unknown operation!");
                    break;
            }
            // If we dont return result of operation, op = null => Exception
            if (op != null)
                Console.WriteLine($"Result = {op(num1, num2)}.");
            // Delay
            Console.ReadKey();
        }
    }
}
