using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// Задание 2. Создайте коллекцию MyList<T>. 
    /// Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List<T>. 
    /// Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
    /// индексатор для получения значения элемента по указанному индексу и свойство только для чтения для 
    /// получения общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле foreach.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //создаём экземпляр класса с начальной вместимостью 20 элементами
            int count = 20;
            MyList<int> list = new MyList<int>(count);

            //получаем начальный размер коллекции
            Console.WriteLine("Capacity: " + list.Capacity);

            //заполняем половину коллекции
            int i = 0;
            while (i < count / 2)
            {
                list.Add(i++);
            }

            //получаем индекс элемента
            Console.WriteLine("Test method IndexOf 2 is: " + list.IndexOf(2));

            //тест методов
            Console.WriteLine("Insert index  2, item - 1000 ");
            list.Insert(2, 1000);
            Console.WriteLine("Insert index  50, item - 10 ");
            list.Insert(50, 10);
            Console.WriteLine("Insert index - 11, item - 100000 ");
            list.Insert(11, 100000);
            Console.WriteLine("Insert index - 2, item - 100 ");
            list.Insert(-2, 100);

            foreach (int item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Contains(2): " + list.Contains(2));
            Console.WriteLine("Contains(-5): " + list.Contains(-5));
            Console.WriteLine("Remove(1000): ");
            list.Remove(1000);
            Console.WriteLine("RemoveAt(1): ");
            Console.WriteLine("RemoveAt(-8): ");
            list.RemoveAt(1);
            list.RemoveAt(-8);
            Console.WriteLine("Count: " + list.Count);

            foreach (int item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            //перебираем в цикле foreach элементы коллекции
            Console.WriteLine("Foreach all items: ");
            foreach (int item in list)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            //получаем итератор всех элементов массива list
            Console.WriteLine("Get iterator all items: ");
            IEnumerable iterator = list.MyListIterator();

            foreach (int item in iterator)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            //получаем итератор элементов массива list от 2 до 8
            Console.WriteLine("Get iterator (2,8 items): ");
            IEnumerable iteratorSection = list.MyListIteratorSection(2, 8);

            foreach (int item in iteratorSection)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Clear()");
            list.Clear();

            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine("Count: " + list.Count);
            Console.ReadKey();
        }
    }
}
