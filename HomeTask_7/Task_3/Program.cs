using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    /// <summary>
    /// Задание 3. Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
    /// среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.
    //  Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
    /// </summary>
    class Program
    {
        //делегат, принимающий в качестве аргументов массив делегатов, 
        //и возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.
        delegate int AverageNumbersDlg(NumberDlg[] delegates);

        //делегат, хранящий метод, генерирующий случайное значение типа int
        delegate int NumberDlg();

        /// <summary>
        /// метод, ассоциированный с делегатом, генерирующий случайное число int
        /// </summary>
        /// <returns>cлучайное число int</returns>
        static int RandNumber()
        {
            Random random = new Random();
            return random.Next(int.MinValue, int.MaxValue);
        }

        static void Main(string[] args)
        {
            //создаём массив делегатов
            int count = 5;
            NumberDlg[] numberHandlers = new NumberDlg[count];

            //определяем методы, которые будут хранить делегаты
            for (int i = 0; i < numberHandlers.Length; i++)
            {
                numberHandlers[i] = new NumberDlg(RandNumber);
            }

            //создаём ананимный метод(делегат)
            AverageNumbersDlg average = delegate (NumberDlg[] numbers)
            {
                //накопительная переменная
                int averageNumbers = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    averageNumbers += numbers[i]();
                }
                //возвращаем среднееарифметическое
                return averageNumbers /= numbers.Length;
            };

            //результат вызова ананимного метода (делеата)
            Console.WriteLine(average(numberHandlers));
            Console.ReadKey();
        }
    }
}
