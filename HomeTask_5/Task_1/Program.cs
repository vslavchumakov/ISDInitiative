using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1-t number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input 2-d number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation:");
            string operation = Console.ReadLine();
            double result = Calculator.Calculate(num1, num2, operation);

            Console.WriteLine("Result:{0}", result);
       
            Console.ReadKey();
        }
    }
}
