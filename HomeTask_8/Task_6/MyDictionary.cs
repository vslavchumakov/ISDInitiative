namespace Task_6
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key = null;
        private readonly TValue[] value = null;
        private readonly int length = 0;

        /// <summary>
        /// Read-only property
        /// </summary>
        public int Length => length;

        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="count">Count of elements</param>
        public MyDictionary(int count)
        {
            // Initializes read-only fields in constructor
            key = new TKey[count];
            value = new TValue[count];
            length = count;
        }

        /// <summary>
        /// An indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                // Checking the existence of an element in the dictionary
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Attempt to go beyond the array.";
            }
        }

        /// <summary>
        /// The method of adding an entry to the dictionary
        /// </summary>
        /// <param name="index"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(int index, TKey addKey, TValue addValue) 
        {
            key[index] = addKey;
            value[index] = addValue;
        }
    }
}
