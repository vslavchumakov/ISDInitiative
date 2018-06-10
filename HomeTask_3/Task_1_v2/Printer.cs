using System;
namespace Task_1_v2
{
    public class Printer
    {
        protected ConsoleColor Color { get; set; } = ConsoleColor.Black;

        // Реализация шаблона NVI
        public void Print(string value) // Шаблонный метод
        {
            SetPrintColor(); // Установка цвета принтера
            Console.WriteLine(value); // Сама печать
            Console.ForegroundColor = ConsoleColor.Black; // Установка цвета принтера в первоначальное значение
        }

        protected virtual void SetPrintColor() // protected делает метод невидимым для клиента
        {
            Console.ForegroundColor = Color; // Базовая функциональность принтера - печать черным
        }
    }
}