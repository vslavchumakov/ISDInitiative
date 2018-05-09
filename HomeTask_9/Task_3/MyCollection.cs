using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDictionary
{

    /// <summary>
    /// вложенный класс необощенной коллекции, реализующий интерфейс  ICollection для перебора ключей и значений 
    /// </summary>
    public class MyCollection<T> : ICollection<T>
    {
        /// <summary>
        /// массив членов коллекции
        /// </summary>
        private T[] _items;

        /// <summary>
        /// конструктор с задаными параметрами
        /// </summary>
        /// <param name="items">члены коллекции</param>
        public MyCollection(T[] items, int count)
        {
            _items = new T[count];
            Array.Copy(items, _items, count);
        }

        /// <summary>
        /// колличество членов коллекции
        /// </summary>
        public int Count => _items.Length;

        /// <summary>
        /// Значение true, если интерфейс ICollection<T> 
        /// доступен только для чтения; в противном случае — значение false.
        /// </summary>
        public bool IsReadOnly => true;

        /// <summary>
        /// добавление члена коллекции
        /// </summary>
        /// <param name="item">новый член коллекции</param>
        public void Add(T item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;
        }

        /// <summary>
        /// очищение колекции
        /// </summary>
        public void Clear()
        {
            _items = new T[0];
        }

        /// <summary>
        /// метод определяем, есть ли в коллекции заданное значение
        /// </summary>
        /// <param name="item">искомый член коллекции</param>
        /// <returns>true- в коллекции есть член со значением, переденным в аргументах, false - в коллекции нет член со значением, переденным в аргументах</returns>
        public bool Contains(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// копирование членов коллекции в массив, переданный в качестве аргумента
        /// </summary>
        /// <param name="array">массив куда копируем члены текущей коллекции</param>
        /// <param name="arrayIndex">индекс начиная с которого начинаем копировать</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            //перебираем элементы массива текущего контейнера начиная с 0
            //перебираем элементы array начиная с arrayIndex
            //идём до последнего элемента текущего контейнера, если это колличество меньше чем вместительность массива array
            //в пративном случае идём до конца массива array
            for (int i = 0; i < ((_items.Length > array.Length - arrayIndex) ? array.Length - arrayIndex : _items.Length); i++)
            {
                array[arrayIndex + i] = _items[i];
            }
        }

        /// <summary>
        /// удаление члена коллекции
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true - член коллекции удален,false- не удален</returns>
        public bool Remove(T item)
        {
            int index = -1;
            for(int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    index = i;break;
                }
            }
            if (index > 0)
            {
                for(int i = index; i < _items.Length; i++)
                {
                    _items[i] = _items[i + 1];
                }
                Array.Resize(ref _items, _items.Length - 1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// получение объекта, который перечисляет члены коллекции
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ItemEnumerator<T>(_items);
        }


        /// <summary>
        /// метод возвращает объект, способный перечислять элементы коллекции, реализующий интерфейс IEnumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ItemEnumerator<T>(_items);
        }
    }
}
