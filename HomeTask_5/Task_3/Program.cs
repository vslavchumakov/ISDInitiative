using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_3
{

        
    public static class ArrayExtension
    {
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
        public static void Print(int []arr)
        {
            Console.WriteLine();
            foreach (int i in arr)
                Console.Write(" {0},",i);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] integers =  new int[15];
            for (int i = 0; i < integers.Length; i++)
                integers[i] = random.Next(10,99);
            Print(integers);
            /// <summary>
            ///пробуем сортировать
            /// </summary>
            integers.ToSortInOrder();
            Print(integers);

            integers.ToSortInOrder(false);
            Print(integers);
            Thread.Sleep(3500);
        }
    }
}
