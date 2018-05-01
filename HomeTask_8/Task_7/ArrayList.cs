namespace Task_7
{
    class ArrayList // Heterogeneous collection
    {
        // private array of object elements
        object[] array = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ArrayList()
        {
            array = new object[0]; // Empty array
        }

        /// <summary>
        /// Read-only property which returns the number of elements in the array
        /// </summary>
        public int Count => array.Length;

        /// <summary>
        /// An indexer
        /// </summary>
        /// <param name="index">Element number in ArrayList</param>
        /// <returns></returns>
        public object this[int index]
        {     
            get
            {
                try { return array[index]; }
                catch { throw; }
            }
        }

        /// <summary>
        /// Method clears an array
        /// </summary>
        public void Clear()
        {
            array = new object[0]; // Empty array
        }


        /// <summary>
        /// Method adds a new item to the ArrayList
        /// </summary>
        /// <param name="item">Object item</param>
        public void Add(object item)
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = item;
            array = tempArray;
        }

        /// <summary>
        /// The predicate method determines whether an item is in the ArrayList
        /// </summary>
        /// <param name="item">Search item</param>
        /// <returns>True - item found, False - item not found</returns>
        public bool Contain(object item) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                    return true;
            }
            return false;
        }
    }
}
