﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1.Task_2
{
    class Program
    {
        /// <summary>
        /// запрашиваем у пользователя число
        /// </summary>
        /// <returns>int введенное число</returns>
        private static int ReadNumber()
        {
            string enter;
            do
            {
                Console.Write("ВВедите число: ");
                enter = Console.ReadLine();
            } while (!int.TryParse(enter, out int number));
            return int.Parse(enter);
        }

        static void Main(string[] args)
        {
            int number1 = ReadNumber();
            Console.WriteLine();
            int number2 = ReadNumber();
            Console.WriteLine(number1 > number2 ? number1 : number2);
            Console.ReadKey();
        }
    }
}
