using System;
namespace Task_3
{
    class MyDictionary<TKey, TValue>: IMyDictionary<TKey, TValue> 
    {
        TKey[] key=null;
        TValue[] val=null;
        int count=0;

        public MyDictionary()
        {
            key = new TKey[0];
            val = new TValue[0];
            count = 0;
        }


        /// <summary>
        /// An indexer to retrieve the value of the element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>TValue of the element</returns>
        public TValue this[TKey keyIndex]
        {
            get
            {
                int index = -1;
                try
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        if (keyIndex.Equals(key[i]))
                            index = i;
                    }
                    if (index != -1) return val[index];
                    else throw new IndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("No value for the specified key!");
                    throw;
                }
            }
        }

     
        /// <summary>
        /// Read-only property to obtain the total number of pairs of elements.
        /// </summary>
        public int Count => count;


        /// <summary>
        /// Adds the specified key and value to the dictionary.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        public void Add(TKey addKey, TValue addValue)
        {
            count++;
            Array.Resize(ref key, Count);
            key[Count - 1] = addKey;

            Array.Resize(ref val, Count);
            val[Count - 1] = addValue;
        }
    }
}
