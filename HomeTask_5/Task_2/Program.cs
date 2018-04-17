using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    class Program
    {
        /// <summary>
        /// метод выводит в консоль массив
        /// </summary>
        /// <param name="ints"></param>
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
            int[] ints = new int[] { 12, 8, 45, 1, -9, 3, -99};
            ShowArray(ints);
            ints.ToSort();
            ShowArray(ints);
        }

    }
}
