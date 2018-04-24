using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TheChildClass.Print(null,"First string",2,22.3);
            TheChildClass.Print("Hello, i'm coloreful string in the console!");
            Console.ReadKey();
        }
    }
}
