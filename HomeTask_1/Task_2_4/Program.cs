using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
{
    /// <summary>
    /// Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо»
    /// если пользователь ввел 1 или «Плохо» если пользователь ввел 0 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 0 или 1:");

            int input = Int32.Parse(Console.ReadLine());

            string output = input == 1 ? "Хорошо" : "Плохо";

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
