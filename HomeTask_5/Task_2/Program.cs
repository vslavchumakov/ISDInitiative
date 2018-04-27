using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using  Task_3;

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
        /// метод выводит в консоль массив
        /// </summary>
        /// <param name="ints">массив целочисленных значений</param>
        public static void ShowArray(this int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            int[] integers = new int[] { 12, 8, 45, 1, -9, 3, -99};
            Console.Write("Array of integers: ");
            integers.ShowArray();

            //сортируем массив
            integers.ToSort();
            Console.Write("Sorted array of integers: ");
            integers.ShowArray();

            Thread.Sleep(3500);
            Console.WriteLine("");
            //sorting again

            integers.ToSortInOrder();
            Console.Write("Sorted array of integer ascending: ");
            integers.ShowArray();

            integers.ToSortInOrder(false);
            Console.Write("Sorted array of integer dascending: ");
            integers.ShowArray();

            Console.ReadKey();
        }
    }
}
