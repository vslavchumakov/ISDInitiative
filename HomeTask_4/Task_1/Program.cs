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
            Editor edt = new Editor();

            Console.WriteLine("First example");
            edt.DefineFormatDocument("my_hometask_4.doc");
            edt.Open();
            edt.Change();
            edt.Save();

            Console.WriteLine(new string('-', 15));

            Console.WriteLine("Second example");
            edt.DefineFormatDocument("noname.xml");
            edt.Create();
            edt.Open();
            edt.Change();
            edt.Save();


            Console.WriteLine(new string('-', 15));

            Console.WriteLine("Third example");
            edt.DefineFormatDocument("my.xxx");
          

            // Delay.
            Console.ReadKey();

        }
    }
}
