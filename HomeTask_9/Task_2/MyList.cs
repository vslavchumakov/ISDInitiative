﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// обобщенная коллекция аналог List
    /// </summary>
    /// <typeparam name="T">тип элементов коллекции</typeparam>
    class MyList<T> : IList<T>, IEnumerable<T>
    {
        /// <summary>
        /// массив элементов коллекции
        /// </summary>
        T[] _items;

        /// <summary>
        /// колличество добавленных элементов в коллекцию
        /// </summary>
        int _count = 0;

        /// <summary>
        /// геттер колличества элементов в коллекции
        /// </summary>
        public int Count => _count;

        /// <summary>
        /// общее число элементов, которые может вместить 
        /// внутренняя структура данных без изменения размера
        /// </summary>
        int _capacity = 5;

        /// <summary>
        /// Возвращает общее число элементов,
        /// которые может вместить внутренняя структура данных без изменения размера.
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;
                Array.Resize(ref _items, _capacity);
            }
        }

        /// <summary>
        /// определяем индексатор, метод выбрасывает исключение, если индекс за пределами диапазона значений
        /// </summary>
        /// <param name="index">индекс текущего элемента</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _count)
                {
                    return _items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (index >= 0 && index < _count)
                {
                    _items[index] = value;
                }
                else if (index == _count)
                {
                    Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Значение true, если интерфейс ICollection<T> 
        /// доступен только для чтения; в противном случае — значение false.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// добавление элемента коллекцию
        /// </summary>
        /// <param name="item">новый элемент коллекции</param>
        public void Add(T item)
        {
            //перевыделяем память, если это необходимо
            if (Count >= _items.Length)
            {
                Array.Resize(ref _items, (int)1.5 * _items.Length);
            }
            _items[_count++] = item;
        }


        /// <summary>
        /// очищение коллекции
        /// </summary>
        public void Clear()
        {
            Array.Clear(_items, 0, Count);
            _count = 0;
        }

        /// <summary>
        /// метод определяем, является объект элементом коллекции
        /// </summary>
        /// <param name="item">объект, который ищим в коллекции</param>
        /// <returns>true - такой элемент есть в коллекции, false - такого элемента нет в коллекции</returns>
        public bool Contains(T item)
        {
            return IndexOf(item) > 0;
        }

        /// <summary>
        /// копирование элементы коллекции ICollection в массив Array, начиная с указанного индекса массива Array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
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
        /// метод находит индекс первого элемента в массиве
        /// </summary>
        /// <param name="item">элемент, индекс которого нужно найти</param>
        /// <returns>индекс элемента, если не найден, возвращаём -1</returns>
        public int IndexOf(T item)
        {
            if (item == null || _count == 0)
            {
                return -1;
            }

            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// вставка элемента по индексу
        /// </summary>
        /// <param name="index">индекс куда нужно вставить элемент</param>
        /// <param name="item">элемент, который добавляется в коллекцию</param>
        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                return;
            }

            if (index == Count)
            {
                Add(item);
                return;
            }

            if (Count >= _items.Length)
            {
                Array.Resize(ref _items, (int)1.5 * _items.Length);
            }

            for (int i = Count; i >= index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = item;
            _count++;
        }

        /// <summary>
        /// удаление элемента
        /// </summary>
        /// <param name="item">элемент, который нужно удалить</param>
        /// <returns>элемент удалён</returns>
        public bool Remove(T item)
        {
            if (Contains(item))
            {
                RemoveAt(IndexOf(item));
                return true;
            }
            return false;
        }

        /// <summary>
        /// удаление элемента коллекции по индексу
        /// </summary>
        /// <param name="index">индекс элемента, который нужно удалить</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                return;
            }

            for (int i = index; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
        }

        /// <summary>
        /// Метод возвращает экземпляр класса, реализующий интерфейс IEnumerator - MyListEnumerator
        /// </summary>
        /// <returns>экземпляр класса MyListEnumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator(_items, Count);
        }

        /// <summary>
        /// именнованный итератор части коллекции
        /// </summary>
        /// <param name="start">начальное значение</param>
        /// <param name="end">конечное значение</param>
        /// <returns>экземпляры коллекции</returns>
        public IEnumerable MyListIteratorSection(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return _items[i];
            }
        }

        /// <summary>
        /// именнованный итератор
        /// </summary>
        /// <returns>экземпляры коллекции</returns>
        public IEnumerable MyListIterator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        /// <summary>
        /// Метод возвращает экземпляр класса, реализующий интерфейс IEnumerator - MyListEnumerator
        /// </summary>
        /// <returns>экземпляр класса MyListEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public MyList()
        {
            _items = new T[_capacity];
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public MyList(int size) : this()
        {
            Capacity = size;
        }

        /// <summary>
        /// класс, реализующий доступ к отдельным элементам коллекции
        /// </summary>
        private class MyListEnumerator : IEnumerator<T>
        {
            /// <summary>
            /// вспомагательная переменная для реализации интерфейса IEnumerable
            /// </summary>
            int _counter = -1;

            /// <summary>
            /// ссылка на массив, перебираемых элементов
            /// </summary>
            T[] items = new T[0];

            /// <summary>
            /// колличество добавленных элеметов в массиве
            /// </summary>
            private int _count;

            /// <summary>
            /// получение текущего элемента
            /// </summary>
            public T Current => items[_counter];

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
            /// получение следующего
            /// </summary>
            /// <returns>true-дальше можно передвигаться по массиву false-достигнут последний элемент массива</returns>
            public bool MoveNext()
            {
                _counter++;
                return _counter < _count;
            }

            /// <summary>
            /// сброс на начало
            /// </summary>
            public void Reset()
            {
                _counter = -1;
            }

            /// <summary>
            /// конструктор перечислителя
            /// </summary>
            /// <param name="items">массив перечисляемых объектов</param>
            public MyListEnumerator(T[] items, int count)
            {
                this.items = items;
                this._count = count;
            }

            /// <summary>
            /// конструктор перечислителя
            /// </summary>
            /// <param name="items">массив перечисляемых объектов</param>
            public MyListEnumerator(T[] items, int start, int end)
            {
                Array.Copy(items, start, this.items, 0, end - start);
            }
        }
    }
}