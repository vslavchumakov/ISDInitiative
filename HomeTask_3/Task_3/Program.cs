using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.GetInfo();

            Ship ship = new Ship();
            ship.GetInfo();

            Console.ReadKey();
        }
    }
}
