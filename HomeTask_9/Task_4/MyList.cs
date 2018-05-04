using System.Collections;
using System.Collections.Generic;

namespace Task_4
{
    /// <summary>
    /// User implementation of the List<T> class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyList<T>: IEnumerable<T>
    {
        /// <summary>
        /// Field
        /// </summary>
        private T[] array= new T[0]; // array

        /// <summary>
        /// An indexer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i] => array[i];

        /// <summary>
        /// The method of adding an entry to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            T[] newArray = new T[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[array.Length] = item;
            array = newArray;
        }

        /// <summary>
        /// Property for the length
        /// </summary>
        public int Count => array.Length;

        int position = -1;

        // 1. Read-only property Current
        public object Current =>array[position];
        // 2. Method MoveNext()
        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else { Reset(); return false; }
        }
        // 3. Method Reset()
        public void Reset()
        {
            position = -1;
        }

        #region IEnumerable<T> Members
        // Method GetEnumerator()
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
                yield return item;
        }
        #endregion

        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
        #endregion
    }
}
