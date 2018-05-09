using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDictionary
{

    /// <summary>
    /// класс реализующий интерфейс IEnumerator<KeyValuePair<TKey, TValue>>, для перечисления элементов коллекции
    /// </summary>
    public class MyDictionaryEnumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>
    {
        /// <summary>
        /// вспомагательная переменная, счётчик
        /// </summary>
        int _counter = -1;

        /// <summary>
        ///  массив ключей
        /// </summary>
        TKey[] _keys;

        /// <summary>
        /// массив значений
        /// </summary>
        TValue[] _values;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="keys">массив ключей</param>
        /// <param name="values">массив значений</param>
        /// <param name="count">колличество членов коллекции</param>
        public MyDictionaryEnumerator(TKey[] keys, TValue[] values, int count) 
        {
            _keys = new TKey[count];
            _values = new TValue[count];
            Array.Copy(keys, _keys, count);
            Array.Copy(values, _values, count);
        }

        /// <summary>
        /// получение текущего члена коллекции
        /// </summary>
        public KeyValuePair<TKey, TValue> Current =>  new KeyValuePair<TKey, TValue>(_keys[_counter],_values[_counter]);
        object IEnumerator.Current => Current;

        /// <summary>
        /// Выполняет определяемые приложением задачи,
        /// связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        {}

        /// <summary>
        /// получение следующего
        /// </summary>
        /// <returns>true-дальше можно передвигаться по массиву false-достигнут последний элемент массива</returns>
        public bool MoveNext()
        {
            _counter++;
            return _counter < _keys.Length;
        }

        /// <summary>
        /// сброс на начало
        /// </summary>
        public void Reset()
        {
            _counter = -1;
        }
    }
}
