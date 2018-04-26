using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Calculator
    {
        private static double result;

        public static double Result { get => result; private set => result = value; }

        public enum EnumOperator
        {
            Add,
            Subtraction,
            Multiply,
            Divided
        }
        private static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        private static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double Divided(double num1, double num2)
        {
            return num1 / num2;
        }

        internal static double Calculate(double operand1, double operand2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Result = Add(operand1, operand2);
                    break;
                case "-":
                    Result = Subtraction(operand1, operand2);
                    break;
                case "*":
                    Result = Multiply(operand1, operand2);
                    break;
                case "/":
                    Result = Divided(operand1, operand2);
                    break;
            }
            return Result;
        }
    }
}
