using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
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

            foreach (var item in myList)
            {
                Console.WriteLine($"Collection item: {item}");
            }

            Console.WriteLine($"The collection size {myList.Count} elements.");

            Console.ReadKey();
        }
    }
}
