#region Hometask_01_3_2
//
// Author: Shemet Viktoriya
// Description: The user enters a number.
// Display the number of digits in it.
//
#endregion
using System;
namespace Task_3_2
{
    class Program
    {
        /// <summary>
        /// This Method count digits in a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static byte CountDigits(uint number)
        {
            byte count = 1;
            while (number > 9)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            string enter;
            Console.Write("Enter a number: ");
            enter = Console.ReadLine();
            if (uint.TryParse(enter, out uint number))
            {
                Console.WriteLine($"{number} has {CountDigits(number)} digits");
            }
            else
            {
                Console.WriteLine("You entered not a number or not unsigned integer.");
            }
            Console.ReadKey();
        }
    }
}
