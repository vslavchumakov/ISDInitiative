using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class TheChildClass:Printer
    {
        public static new void Print(string str)
        {
            Printer.Print(str);
        }
    }
}
