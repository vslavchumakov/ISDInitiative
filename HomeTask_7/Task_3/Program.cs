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
        delegate int AverageNumbersHandler(NumberHandler[] delegates);

        //делегат, хранящий метод, генерирующий случайное значение типа int
        delegate int NumberHandler();

        /// <summary>
        /// метод, ассоциированный с делегатом, генерирующий случайное число int
        /// </summary>
        /// <returns>cлучайное число int</returns>
        static int NumberHandlerMethod()
        {
            Random random = new Random();
            return random.Next(int.MinValue, int.MaxValue);
        }

        static void Main(string[] args)
        {
            //создаём массив делегатов
            int count = 5;
            NumberHandler[] arrayNumbers = new NumberHandler[count];

            //определяем методы, которые будут хранить делегаты
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = new NumberHandler(NumberHandlerMethod);
                //допустима и короткая запись
                //arrayDlgs[i] = RandNumber;
            }

            //создаём анонимный метод(делегат)
            AverageNumbersHandler averageHandler = delegate (NumberHandler[] arrayNumberHandlers)
            {
                //накопительная переменная
                long averageNumbers = 0;

                for (int i = 0; i < arrayNumberHandlers.Length; i++)
                {
                    //проверка, что делегат содержит ссылку на метод, не null
                    if (arrayNumbers[i] != null)
                    {
                        averageNumbers += arrayNumberHandlers[i]();
                    }
                }
                //возвращаем среднееарифметическое
                return (int)(averageNumbers /= arrayNumberHandlers.Length);
            };
            
            //результат вызова анонимного метода (делегата)
            Console.WriteLine("Use delegate, Average int is: " + averageHandler(arrayNumbers));



            //--------------------------------------------------------------------------------------------------
            //вариант 2 - создаём анонимный метод(делегат Func<NumberHandler[],int>)
            Func<NumberHandler[],int> averageFunc = delegate (NumberHandler[] arrayNumberHandlers)
            {
                //накопительная переменная
                long averageNumbers = 0;

                for (int i = 0; i < arrayNumberHandlers.Length; i++)
                {
                    //проверка, что делегат содержит ссылку на метод, не null
                    if (arrayNumbers[i] != null)
                    {
                        averageNumbers += arrayNumberHandlers[i]();
                    }
                }
                //возвращаем среднееарифметическое
                return (int)(averageNumbers /= arrayNumberHandlers.Length);
            };
            
            //результат вызова анонимного метода (делегата)
            Console.WriteLine("Use Func<T[],int> Average int is: " + averageFunc(arrayNumbers));
            
            Console.ReadKey();
        }
    }
}
