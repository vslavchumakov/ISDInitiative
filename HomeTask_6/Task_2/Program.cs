using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        /// <summary>
        /// Задание 2. Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
        // Написать программу, выполняющую следующие действия:
        // - ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть упорядочены по номерам поездов);
        // - вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести соответствующее сообщение).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //максимальное колличество поездов в парке
            int size = 8;

            //создаём массив поездов
            Train[] trains = new Train[size];

            //колличество поездов в массиве
            int count = 0;
            trains[count++] = new Train("Dnipro", 34, new DateTime(2019, 2, 15));
            trains[count++] = new Train("Lviv", 79, new DateTime(2019, 1, 3));

            //запускаем меню
            Menu.StartMenu(trains, ref count);
        }
    }
}
