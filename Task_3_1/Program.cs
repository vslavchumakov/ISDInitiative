using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Запрашиваем у пользователя число на ввод
            /// </summary>
            bool correctNumberInput = false;
            int number=0;
            string userInputNumber;

            while (!correctNumberInput)
            {
                Console.WriteLine("Введите число:"); Console.Write("->");
                userInputNumber = Console.ReadLine();
                if (!int.TryParse(userInputNumber, out number))
                {
                    Console.WriteLine("Вы неправельно ввели число.");
                }
                else
                    correctNumberInput = true;
            }
            /// <summary>
            /// Выводим таблицу
            /// </summary>
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("\t{0}\t*\t{1}\t=\t{2}",i, number, number*i);
            }
            Console.ReadKey();
        }
    }
}
