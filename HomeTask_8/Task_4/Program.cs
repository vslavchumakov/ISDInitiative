using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i.ToString());
            }

            string[] array = myList.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Collection item: {array[i]}");
            }

            Console.ReadKey();
        }
    }
}
