using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDictionary
{
    /// <summary>
    /// класс реализующий интерфейс IEnumerator<T> для перечисления элементов коллекции
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemEnumerator<T> : IEnumerator<T>
    {
        /// <summary>
        /// вспомагательная переменная для перебора
        /// </summary>
        int _counter = -1;

        /// <summary>
        /// ссылка на массив, перебираемых элементов
        /// </summary>
        T[] _items;

        /// <summary>
        /// получение текущего элемента
        /// </summary>
        public T Current => _items[_counter];

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public ItemEnumerator(T[] items)
        {
            _items = items;
        }

        /// <summary>
        /// получение текущего элемента
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// Выполняет определяемые приложением задачи,
        /// связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        { }

        /// <summary>
        /// получение следующего элемента
        /// </summary>
        /// <returns>true-возможно получить следующий элемент,false-дошли до конца коллекции</returns>
        public bool MoveNext()
        {
            _counter++;
            return _counter < _items.Length;
        }

        /// <summary>
        /// метод сбрасывает счётчик
        /// </summary>
        public void Reset()
        {
            _counter = -1;
        }
    }
}
