using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_7
{
    class Program
    {
        /// <summary>
        /// 3.7. У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все сочетания)?
        /// </summary>
        static void Main(string[] args)
        {
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    if (i*2 + j*4 == 64)
                    {
                        Console.WriteLine("Гусей: {0}, Кроликов: {1}", i, j);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
