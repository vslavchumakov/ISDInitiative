using System;
namespace Task_1_v2
{
    public class PrinterColor : Printer
    {
        public PrinterColor(ConsoleColor color)
        {
            Color = color;
        }

        // Тут неявно есть метод  Print из базового класса Printer
        /*
        public void Print(string value) // Шаблонный метод
        {
            SetPrintColor(); // Установка цвета принтера
            Console.WriteLine(value); // Сама печать
            Console.ForegroundColor = ConsoleColor.Black; // Установка цвета принтера в первоначальное значение
        } 
        */

        protected override void SetPrintColor() // Вот тут задаем цвет печати принтера, который передали в конструктор
        {
            Console.ForegroundColor = Color;
        }
    }
}