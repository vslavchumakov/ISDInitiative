using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Запрашиваем у пользователя число на ввод
            /// </summary>
            bool correctNumberInput = false;
            float avgNumber = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int fifthNumber = 0;
            string userInputNumber;

            while (!correctNumberInput)
            {
                Console.WriteLine("Введите первое число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out firstNumber))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            correctNumberInput = false;
            while (!correctNumberInput)
            {
                Console.WriteLine("Введите второе число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out secondNumber))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            correctNumberInput = false;
            while (!correctNumberInput)
            {
                Console.WriteLine("Введите третье число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out thirdNumber))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            correctNumberInput = false;
            while (!correctNumberInput)
            {
                Console.WriteLine("Введите четвертое число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out fourthNumber))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            correctNumberInput = false;
            while (!correctNumberInput)
            {
                Console.WriteLine("Введите пятое число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out fifthNumber))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            /// <summary>
            /// Выводим среднее арефметическое
            /// </summary>
            avgNumber = ((float)(firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber))/ 5;
            Console.WriteLine("Среднее Арефметическое {0},{1},{2},{3},{4} будет:{5}",firstNumber,secondNumber,thirdNumber,fourthNumber,fifthNumber,avgNumber);
            Console.ReadKey();
        }
    }
}
