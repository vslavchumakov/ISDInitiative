using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_5
{
    /// <summary>
    /// 2.5. Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье) 
    /// </summary>
    class Program
    {
        /// <summary>
        /// запрашиваем у пользователя день недели
        /// </summary>
        /// <returns>int день недели</returns>
        private static int GetDay()
        {
            string enter;
            int min = 1;
            int max = 7;
            while (true)
            {
                Console.Write("Введите число от 1 до 7: ");
                enter = Console.ReadLine();
                if (int.TryParse(enter, out int number))
                {
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                }
            };
        }

        static void Main(string[] args)
        {
            int day = GetDay();
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскрксенье");
                    break;
            }
            Console.ReadKey();
        }
    }
}
