using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// класс обобщенной коллекции автомобилей
    /// </summary>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    public class CarCollection<T> where T : Car, new()//ограничение:
                                                      //тип должен быть Car или его наследником
                                                      //тип должен иметь открытый конструктор без параметров
    {
        /// <summary>
        /// массив элементов 
        /// </summary>
        T[] Elements = new T[countResize];

        /// <summary>
        /// шаг увеличения коллекции, принимаем 2 для тестирования добавления элементов в коллекцию
        /// </summary>
        const int countResize = 2;

        /// <summary>
        /// колличество добавленных автомобилей
        /// </summary>
        int count = 0;

        /// <summary>
        /// определяем индексатор для возможности перебора элементов коллекции с помощью []
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns></returns>
        public T this[int i] => Elements[i];

        /// <summary>
        /// метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="element">добавляемый экзкмпляр коллекции</param>
        public void Add(T element)
        {
            //если в коллекции добавлено элементов меньше чем вместительность, добавляем новый элемент,
            //иначе перевыделяем память
            if (count >= Elements.Length)
            {
                T[] NewElements = new T[Elements.Length + countResize];
                for (int i = 0; i < Elements.Length; i++)
                {
                    NewElements[i] = Elements[i];
                }
                Elements = NewElements;

                //отладка
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("add element-memory realloc");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Elements[count++] = element;
        }

        /// <summary>
        /// метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="element">добавляемый экзкмпляр коллекции</param>
        public void Add(string name, int year)
        {
            Add(new T() { Name = name, YearCreation = year });
        }

        /// <summary>
        /// свойство с методом доступа get для получения фактического колличества экзкмпляров коллекции
        /// </summary>
        public int Count
        {
            get => count;
        }

        /// <summary>
        /// метод очищенния массива
        /// </summary>
        public void Clear()
        {
            Array.Clear(Elements, 0, Count);
            count = 0;
        }

        /// <summary>
        /// переопределяем ToString()
        /// </summary>
        /// <returns>строковое представление объекта</returns>
        public override string ToString()
        {
            StringBuilder data = new StringBuilder("Count elements: " + Count + "\n");
            for (int i = 0; i < Count; i++)
            {
                data.Append(Elements[i]);
                data.Append("\n");
            }
            data.Append("\n");
            return data.ToString();
        }
    }
}
