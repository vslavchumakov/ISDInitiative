using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_2
{
    /// <summary>
    /// класс взаимодействия с пользователем
    /// </summary>
    static class Menu
    {
        /// <summary>
        /// метод запускает меню
        /// </summary>
        /// <param name="trains">массив поездов</param>
        /// <param name="count">колличество поездов в массиве</param>
        public static void StartMenu(Train[] trains, ref int count)
        {
            //очищаем консоль
            Clear();
            do
            {
                WriteLine("       Main menu:");
                WriteLine((int)MenuItem.ShowTrains + " - Show information of all trains,");
                WriteLine((int)MenuItem.AddTrain + " - Add train,");
                WriteLine((int)MenuItem.Exit + " - Exit");

                string choice = null;
                int answer = 0;
                do
                {
                    Write("Your choice: ");
                    choice = ReadLine();
                } while (!int.TryParse(choice, out answer));
                WriteLine("--------------------------------");

                switch ((MenuItem)answer)
                {
                    case MenuItem.ShowTrains:
                        Menu.ShowTrains(trains, count);
                        break;
                    case MenuItem.AddTrain:
                        Menu.AddTrain(trains, ref count);
                        break;
                    case MenuItem.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Error iteam menu...");
                        break;
                }
                WriteLine("Done!");
                ReadKey();//пауза
                Clear();//очистка консоли
            } while (true);
        }

        /// <summary>
        /// метод выводит в консоль информацию о поездах
        /// </summary>
        /// <param name="trains">массив поездов</param>
        /// <param name="count">колличество поездов в массиве</param>
        private static void ShowTrains(Train[] trains, int count)
        {
            for (int i = 0; i < count; i++)
            {
                WriteLine(trains[i]);
            }
        }

        /// <summary>
        /// метод добавления поезда
        /// </summary>
        /// <param name="trains">массив поездов</param>
        /// <param name="count">колличество поездов в массиве</param>
        private static void AddTrain(Train[] trains, ref int count)
        {
            if (count == trains.Length)
            {
                WriteLine("Array is full!");
                return;
            }

            //запрашиваем пункт назначения
            Write("Enter destination: ");
            string destination = ReadLine();

            //запрашиваем номер поезда
            int number = GetData("Enter number train: ");

            //запрашиваем данные о поезде
            DateTime date = GetDateTime();

            //Создаём новый поезд
            Train train = new Train(destination, number, date);

            //добавляем поезд в массив
            AddTrainToArray(trains, ref count, train);
        }

        /// <summary>
        /// метод добавляем поезд в массив в соответствии с номером поезда(сортировка при вставке)
        /// </summary>
        /// <param name="trains">массив поездов</param>
        /// <param name="count">колличество добавленных поездов</param>
        /// <param name="train">добавляемый поезд</param>
        private static void AddTrainToArray(Train[] trains, ref int count, Train train)
        {
            //искомое место для элемента
            int index = 0;

            //перебираем массив ищим место вставки
            for (int i = 0; i < count; i++)
            {
                if (trains[i].NumberTrain < train.NumberTrain)
                {
                    index = i + 1;
                }
                else
                {
                    break;
                }
            }

            //сдвигаем элементы массива
            for (int j = count; j > index; j--)
            {
                trains[j] = trains[j - 1];
            }

            //добавляем поезд
            trains[index] = train;
            count++;
        }

        /// <summary>
        /// метод получения даты и времени прибытия поезда
        /// </summary>
        /// <returns>структура дата время</returns>
        private static DateTime GetDateTime()
        {
            //валидация введенных данных даты пользователем
            bool isValidDateTime;

            //время прибытия
            DateTime date = DateTime.Now;

            do
            {
                isValidDateTime = true;
                int year = GetData("Enter year: ");
                int month = GetData("Enter month: ");
                int day = GetData("Enter day: ");
                try
                {
                    date = new DateTime(year, month, day);
                }
                catch (ArgumentOutOfRangeException exception)//ловим исключение не верной даты
                {
                    WriteLine(exception.Message);
                    isValidDateTime = false;
                }
            } while (!isValidDateTime);

            return date;
        }


        /// <summary>
        /// метод возвращет запрашиваемое число у пользователя
        /// </summary>
        /// <param name="msg">сообщение пользователю</param>
        /// <returns></returns>
        private static int GetData(string msg)
        {
            string data = null;
            int number = 0;
            do
            {
                Write(msg);
                data = ReadLine();
            } while (!int.TryParse(data, out number));
            return number;
        }
    }
}
