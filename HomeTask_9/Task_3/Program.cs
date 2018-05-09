using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDictionary
{
    /// <summary>
    /// 
    /// Автор Куликова Ирина
    /// 
    /// Задание 3. Создайте коллекцию MyDictionary<TKey,TValue>.
    /// Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>.
    /// Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
    /// индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.
    /// Реализуйте возможность перебора элементов коллекции в цикле foreach.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //создаём объект класса  MyDictionary<string, string>
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>
            {
                { "Привет", "Hello" },
                { "Пока", "Bay" },
                { "Игра", "Project" },
                { "Учёба", "Study" },
                { "Задание", "Task" },
                { "Словарь", "Dictionary" },
                { "Список", "List" },
                { "Таблица", "Table" }
            };

            Console.WriteLine("foreach");
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }

            Console.Write("\nTest Indexer: get by key <Список> => ");
            dictionary.TryGetValue("Привет", out string data);
            Console.WriteLine(data);

            Console.WriteLine("Count: " + dictionary.Count);
            Console.WriteLine("Capacity: " + dictionary.Capacity);

            Console.WriteLine("\n\n Get Collection Keys and foreach items of this collection: ");
            ICollection<string> collectionKeys = dictionary.Keys;
            foreach (string item in collectionKeys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n Get Collection Values and foreach items of this collection: ");
            ICollection<string> collectionValues = dictionary.Values;
            foreach (string item in collectionValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nTest Remove by key <Игра>: and foreach dictionary");
            dictionary.Remove("Игра");
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }
            Console.WriteLine("Count: " + dictionary.Count);

            Console.WriteLine("\n\nTest copy to");
            int count = 2;
            //создаём массив узлов словаря
            KeyValuePair<string, string>[] copy = new KeyValuePair<string, string>[count];
            dictionary.CopyTo(copy, 0);
            for (int i = 0; i < copy.Length; i++)
            {
                Console.WriteLine(copy[i].Key + " => " + copy[i].Value);
            }

            Console.WriteLine("\n\nTest Remove  KeyValuePair<Список,List> and foreach");
            dictionary.Remove(new KeyValuePair<string, string>("Список", "List"));
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }
            Console.WriteLine("Count: " + dictionary.Count);
            Console.WriteLine("Capacity: " + dictionary.Capacity);
            Console.WriteLine("\n\nClear");
            dictionary.Clear();
            Console.WriteLine("Count: " + dictionary.Count);
            Console.WriteLine("Capacity: " + dictionary.Capacity);

            Console.WriteLine("\n\nTest Add(KeyValuePair<string, string>)");
            dictionary.Add(new KeyValuePair<string, string>("День", "Day"));
            dictionary.Add(new KeyValuePair<string, string>("Ночь", "Nigth"));
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }
            Console.WriteLine("Count: " + dictionary.Count);
            Console.WriteLine("Capacity: " + dictionary.Capacity);
            Console.ReadKey();
        }
    }
}
