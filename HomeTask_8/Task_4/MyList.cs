using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] list;
        private int index = 0;
        
        public T this[int i] => list[i];

        public int Count { get => list.Length;}

        public void Add(T value)
        {
            if (list == null)
                list = new T[1];
            if (list.Length == index)
                Array.Resize(ref list, list.Length + 1);
            list[index] = value;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
