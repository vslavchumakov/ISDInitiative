using System.Collections.Generic;

namespace Task_4
{
    // Extension methods must be defined in a static class
    static class ExtensionMyList
    {
        /// <summary>
        /// An extension method that copies list items to an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The first parameter takes the "this" modifier</param>
        /// <returns></returns>
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int i = 0;
            T[] array = new T[i];
            foreach (T item in list)
            {
                T[] newArray = new T[array.Length + 1];
                array.CopyTo(newArray, 0);
                newArray[array.Length] = item;
                array = newArray;
            }
            return array;
        }
    }
}
