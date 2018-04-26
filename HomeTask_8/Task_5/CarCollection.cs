using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// класс обобщенная коллекция автомобилей
    /// </summary>
    /// <typeparam name="T">Тип элементов коллекции</typeparam>
    public class CarCollection<T> where T : Car, new()//ограничение:
                                                      //тип должен быть Car или его наследником
                                                      //тип должен иметь открытый конструктор без параметров
    {
        /// <summary>
        /// массив элементов 
        /// </summary>
        T[] _elements = new T[countResize];

        /// <summary>
        /// шаг увеличения коллекции, принимаем 2 для тестирования добавления элементов в коллекцию
        /// </summary>
        const int countResize = 2;

        /// <summary>
        /// колличество добавленных элементов
        /// </summary>
        int _count = 0;

        /// <summary>
        /// определяем индексатор для возможности перебора элементов коллекции с помощью []
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns></returns>
        public T this[int i] => _elements[i];

        /// <summary>
        /// метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="element">добавляемый элемента коллекции</param>
        public void Add(T element)
        {
            //если в коллекции добавлено элементов меньше чем вместительность, добавляем новый элемент,
            //иначе перевыделяем память
            if (Count >= _elements.Length)
            {
                Resize();
            }
            _elements[_count++] = element;
        }

        /// <summary>
        /// метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="element">добавляемый элемент коллекции</param>
        public void Add(string name, int year)
        {
            Add(new T() { Name = name, YearCreation = year });
        }

        /// <summary>
        /// свойство с методом доступа get для получения фактического колличества элементов коллекции
        /// </summary>
        public int Count
        {
            get => _count;
        }

        /// <summary>
        /// метод очищенния коллекции
        /// </summary>
        public void Clear()
        {
            Array.Clear(_elements, 0, Count);
            _count = 0;
        }

        /// <summary>
        /// получение индекса элемента
        /// </summary>
        /// <param name="element">элемент, который ищим</param>
        /// <returns>индекс элемента в коллекции</returns>
        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (element == _elements[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// метод проверяет принадлежность объекта коллекции
        /// </summary>
        /// <param name="element">элемент который хотим найти</param>
        /// <returns>true- этот элемент пренадлежит коллекции, false- такого элемента в коллекции нет</returns>
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
        }

        /// <summary>
        /// удаление элемента по индексу
        /// </summary>
        /// <param name="index">индекс элемента, который нужно удалить</param>
        public void RemoveAt(int index)
        {
            //если индекс находится за диапозонами коллекции
            if (index < 0 || index > Count - 1)
            {
                return;
            }
            else
            {
                //передвигаем элементы, освобождаем место
                for (int i = index; i < Count; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _count--;
            }
        }

        /// <summary>
        /// метод вставки элемента
        /// </summary>
        /// <param name="index">индекс для вставки</param>
        /// <param name="element">новый елемент коллекции</param>
        public void Insert(int index, T element)
        {
            //если индекс назодится за пределами коллекции
            if (index < 0 || index > Count)
            {
                return;
            }

            //добавление в конец
            if (index == Count)
            {
                Add(element);
            }
            //добавление в середину
            else
            {
                //если нужно, перевыделяем память
                if (Count >= _elements.Length)
                {
                    Resize();
                }
                //передвигаем элементы, освобождаем место
                for (int i = Count; i >= index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }

                //вставляем элемент
                _elements[index] = element;
                _count++;
            }
        }

        /// <summary>
        /// метод удаления по ссылке
        /// </summary>
        /// <param name="element">ссылка на элемент, который нужно удалить из коллекции</param>
        public void Remove(T element)
        {
            for(int i = 0; i < Count; i++)
            {
                if (element == _elements[i])
                {
                    RemoveAt(i);
                    return;
                }
            }
        }

        /// <summary>
        /// метод перевыделения памяти
        /// </summary>
        private void Resize()
        {
            T[] NewElements = new T[_elements.Length + countResize];
            for (int i = 0; i < _elements.Length; i++)
            {
                NewElements[i] = _elements[i];
            }
            _elements = NewElements;

            //отладка
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("add element-memory realloc");
            Console.ForegroundColor = ConsoleColor.Gray;
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
                data.Append(_elements[i]);
                data.Append("\n");
            }
            data.Append("\n");
            return data.ToString();
        }
    }
}
