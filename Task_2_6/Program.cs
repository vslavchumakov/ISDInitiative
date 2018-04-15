using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Запрашиваем и проверяем у пользователя данные на ввод
            /// </summary>
            bool correctKilometrInput = false;
            bool correctWaitingTimeInput = false;
            string userInputKilometres;
            string userInputWaitingTime;
            int waitingTime=0;
            float distance=0;
            float journeyСost;

            while (!correctKilometrInput)
            {
                Console.WriteLine("Введите количество километров в пройденых в пути:"); Console.Write("->");
                userInputKilometres = Console.ReadLine();
                userInputKilometres = userInputKilometres.Replace(".", ",");

                if (!float.TryParse(userInputKilometres, out distance))
                {
                    Console.WriteLine("Вы неправельно ввели растояние.");
                }
                else
                    correctKilometrInput = true;
            }
            while (!correctWaitingTimeInput)
            {
                Console.WriteLine("Введите количество времени простоя в пути:"); Console.Write("->");
                userInputWaitingTime = Console.ReadLine();
                if (!int.TryParse(userInputWaitingTime, out waitingTime))
                {
                    Console.WriteLine("Вы неправельно ввели время простоя.");
                }
                else
                    correctWaitingTimeInput = true;
            }
            /// <summary>
            /// Подсчитываю стоимость поездки
            /// </summary>
            if (distance < 5)
                journeyСost = 20;
            else
                journeyСost = 20 + (distance - 5) * 3;
            journeyСost += waitingTime;
            Console.WriteLine("Стоимость поездки составлят {0} грн.", journeyСost);
            Console.ReadKey();
        }
    }
}
