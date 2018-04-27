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
            string message1 = "Input 1-t number:";
            string message2 = "Input 2-d number:";
            string message3 = "Choose operation:";

            double num1 = InputNumber(message1);
            double num2 = InputNumber(message2);
            string operation = InputOperation(message3);

            double result = Calculator.Calculate(num1, num2, operation);

            Console.WriteLine("Result:{0}", result);
            Console.ReadKey();
        }

        private static string InputOperation(string message)
        {
            string operation;
          
            Regex regex = new Regex("[-+*/]");
            do
            {
                Console.WriteLine(message);
                operation = Console.ReadLine();

            } while (!regex.IsMatch(operation));

            return operation;
        }

        static private double InputNumber(string message)
        {
            string choice = null;
            double number = 0;
            do
            {
                Console.WriteLine(message);
                choice = Console.ReadLine();
            } while (!double.TryParse(choice, out number));
            return number;
        }
    }
}
