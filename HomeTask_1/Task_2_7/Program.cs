#region Hometask_01_2_7
//
// Author: Shemet Viktoriya
// Description: Given a natural number.
// To find out whether it is simple,
// that is, it is divided into 1 and itself.
//
#endregion
using System;

namespace Task_2_7
{
    class Program
    {
        /// <summary>
        /// This method find out whether a natural number is simple
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static string IsSimple(uint number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if ((number % i) == 0)
                    return "not simple";
            }
            return "simple";
        }

        static void Main(string[] args)
        {
            string enter;
            Console.Write("Enter a natural number: ");
            enter = Console.ReadLine();
            if (uint.TryParse(enter, out uint number))
            {
                Console.WriteLine($"{number} is {IsSimple(number)}");
            }
            else
            {
                Console.WriteLine("You entered not a natural number.");
            }
            Console.ReadKey();
        }
    }
}
