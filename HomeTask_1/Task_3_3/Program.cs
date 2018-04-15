using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Program
    {
        /// <summary>
        /// 3.3. Программа загадывает число от 1 до 146. Пользователь пытается его угадать.
        /// В случае не верного ответа программа дает подсказку «больше» или «меньше»
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 146:");

            Random randomValue = new Random();

            int roll = randomValue.Next(1, 146);

            int input;

            do
            {
                input = Int32.Parse(Console.ReadLine());
                if (roll < input)
                {
                    Console.WriteLine("Ваше число больше");
                    Console.WriteLine(roll);
                }
                if (roll > input)
                {
                    Console.WriteLine("Ваше число меньше");
                    Console.WriteLine(roll);
                }
            } while (roll != input);
            Console.WriteLine("Вы угадали число {0}", roll);
            Console.ReadKey();
        }
    }
}
