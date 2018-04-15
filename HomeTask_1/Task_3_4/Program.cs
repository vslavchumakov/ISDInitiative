using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_4
{
    /// <summary>
    /// 3.4. Выведите все точные квадраты натуральных чисел,
    /// которые (квадраты) меньше заданного числа N.
    /// (натуральные - это числа, которые мы используем при счёте: 1, 2, 3 и т.д.)
    /// </summary>
    class Program
    {
        /// <summary>
        /// запрашиваем у пользователя число
        /// </summary>
        /// <returns>int введенное число</returns>
        private static int GetNumber()
        {
            string enter;
            while (true)
            {
                Console.Write("ВВедите число: ");
                enter = Console.ReadLine();
                if ((int.TryParse(enter, out int number) && number > 0))
                {
                    return number;
                }
            };
        }

        /// <summary>
        /// Выводим квадраты натуральных чисел от 1 до n
        /// </summary>
        /// <param name="n">последнее натуральное число вывода</param>
        private static void ShowSquares(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("number : " + i + "    square: " + Math.Pow(i, 2));
            }
        }

        static void Main(string[] args)
        {
            ShowSquares(GetNumber());
            Console.ReadKey();
        }
    }
}
