using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myDictionary
{
    /// <summary>
    /// класс словарь
    /// </summary>
    class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        /// <summary>
        /// коллекция ключей
        /// </summary>
        TKey[] _keys;

        /// <summary>
        /// коллекция значений
        /// </summary>
        TValue[] _values;

        /// <summary>
        /// размер коллекции без перевыделения памяти
        /// </summary>
        int _capacity = 5;

        /// <summary>
        /// размер наполенных элементов коллекции данными
        /// </summary>
        int _count = 0;

        /// <summary>
        /// геттер размера коллекции, счётчик
        /// </summary>
        public int Count => _count;

        /// <summary>
        /// физический размер коллекции
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;
                Array.Resize(ref _keys, _capacity);
                Array.Resize(ref _values, _capacity);
            }
        }

        /// <summary>
        /// конструктор с заданными параметрами
        /// </summary>
        /// <param name="capacity">размер коллекции без перевыделения памяти</param>
        public MyDictionary(int capacity)
        {
            _capacity = capacity;
            _keys = new TKey[_capacity];
            _values = new TValue[_capacity];
        }

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public MyDictionary()
        {
            _keys = new TKey[_capacity];
            _values = new TValue[_capacity];
        }


        /// <summary>
        /// очищение коллекции
        /// </summary>
        public void Clear()
        {
            Array.Clear(_keys, 0, _keys.Length);
            Array.Clear(_values, 0, _values.Length);
            _count = 0;
        }

        /// <summary>
        /// Значение true, если интерфейс ICollection<T> 
        /// доступен только для чтения; в противном случае — значение false.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// перегрузка индексатора
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение по ключю</returns>
        public TValue this[TKey key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return _values[Array.IndexOf(_keys, key)];
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            set
            {
                if (ContainsKey(key))
                {
                    _values[Array.IndexOf(_keys, key)] = value;
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
        }

        /// <summary>
        /// метод возвращает объект реализующий интерфейс ICollection для ключей
        /// </summary>
        public ICollection<TKey> Keys => new MyCollection<TKey>(_keys, Count);

        /// <summary>
        /// метод возвращает объект реализующий интерфейс ICollection для значений
        /// </summary>
        public ICollection<TValue> Values => new MyCollection<TValue>(_values, Count);

        /// <summary>
        /// добавление члена коллекции
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        public void Add(TKey key, TValue value)
        {
            //если такого ключа в словаре нет
            if (!ContainsKey(key))
            {
                if (_count >= _capacity)
                {
                    _capacity = (int)(1.5 * _keys.Length);
                    Array.Resize(ref _keys, _capacity);
                    Array.Resize(ref _values, _capacity);
                }
                _keys[_count] = key;
                _values[_count] = value;
                _count++;
            }
        }

        /// <summary>
        /// добавление члена коллекции
        /// </summary>
        /// <param name="item">объект, содержащий ключ, значение, узел коллекции</param>
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        /// <summary>
        /// метод определяем наличеие члена коллекции, переданого в параметре метода
        /// </summary>
        /// <param name="item">член коллекции</param>
        /// <returns>true-присутствует в коллекции, false-отсутствует в коллекции</returns>
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(item.Key) && _values[i].Equals(item.Value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// метод определяет наличие ключа в коллекции
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>true-присутствует в коллекции, false-отсутствует в коллекции</returns>
        public bool ContainsKey(TKey key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// копирование значений в заданый массив
        /// </summary>
        /// <param name="array">заданный массив</param>
        /// <param name="arrayIndex">индекс начиная с которого начинаем копирование</param>
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            //перебираем элементы массива текущей коллекции начиная с 0
            //перебираем элементы array начиная с arrayIndex
            //идём до последнего элемента текущеей коллекции, если это колличество меньше чем вместительность массива array
            //в пративном случае идём до конца массива array
            for (int i = 0; i < ((_keys.Length > array.Length - arrayIndex) ? array.Length - arrayIndex : _keys.Length); i++)
            {
                array[arrayIndex + i] = new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
            }
        }

        /// <summary>
        /// получение объекта, который умеет перечислять члены коллекции
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new MyDictionaryEnumerator<TKey, TValue>(_keys, _values, _count);
        }

        /// <summary>
        /// удвление члена коллекции по ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(TKey key)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(key))
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _keys[i] = _keys[i + 1];
                    _values[i] = _values[i + 1];
                }
                _count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// удачение члена коллекции, если он равен объекту, переданного в виде аргумента
        /// </summary>
        /// <param name="item">искомый член коллекции</param>
        /// <returns></returns>
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(item.Key) && _values[i].Equals(item.Value))
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _keys[i] = _keys[i + 1];
                    _values[i] = _values[i + 1];
                }
                _count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// проба получить значение члена коллекции по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значение, если ключь не найден, то value=default(TValue)</param>
        /// <returns></returns>
        public bool TryGetValue(TKey key, out TValue value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(key))
                {
                    value = _values[i];
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        /// <summary>
        /// метод предоставляет объект, реализующий интерфейс IEnumerator, способный перечислять члены коллекции
        /// </summary>
        /// <returns>объект класса, реализующий интерфейс IEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
