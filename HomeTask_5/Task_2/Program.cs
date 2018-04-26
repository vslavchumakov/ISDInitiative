using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_2
{
    /// <summary>
    /// Создать расширение для массива челых чисел сортирующее его по возрастанию
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// статический метод
        /// </summary>
        /// <param name="arr">ссылка на тип, к которому добавляем метод расширения</param>
        public static void ToSort(this int[] arr)
        {
            int buffer;
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                buffer = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > buffer; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = buffer;
            }
        }
        /// <summary>
        /// Расширить программу из задачи 2. 
        /// Расширение должно принимать bool 
        /// параметер который задает 
        /// направление сортировки
        /// </summary>
        /// <param name="array">ссылка на тип, к которому добавляем метод расширения</param>
        /// <param name="order">параметр, который указивает направление сортировки
        /// true - ascending, falce - descending</param>
        public static void ToSortInOrder(this int[] array, bool order = true)
        {
            if (order)
                Array.Sort<int>(array, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            else
                Array.Sort<int>(array, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
        }
    }

    class Program
    {
        /// <summary>
        /// метод выводит в консоль массив
        /// </summary>
        /// <param name="ints">массив целочисленных значений</param>
        private static void ShowArray(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i]+" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] integers = new int[] { 12, 8, 45, 1, -9, 3, -99};
            Console.Write("Array of integers: ");
            ShowArray(integers);

            //сортируем массив
            integers.ToSort();
            Console.Write("Sorted array of integers: ");
            ShowArray(integers);

            Thread.Sleep(3500);
            Console.WriteLine("");
            //sorting again

            integers.ToSortInOrder();
            Console.Write("Sorted array of integer ascending: ");
            ShowArray(integers);

            integers.ToSortInOrder(false);
            Console.Write("Sorted array of integer dascending: ");
            ShowArray(integers);

            Console.ReadKey();
        }
    }
}
