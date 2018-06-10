using System;
namespace Task_1_v2
{
    #region Hometask_03_1_v2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Создайте класс Printer.
    // В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
    // Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, 
    // и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
    // Обязательно используйте приведение типов.
    //
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // Выводим на печать строку
            string s = "This new edition of Pro C# 5.0 and the .NET 4.5 Platform" +
            "\n has been completely revised and rewritten to reflect the latest changes" +
            "\n to the C# language specification and new advances in the .NET Framework.";

            // Печатаем черно-белым
            Printer printer = new Printer();
            printer.Print(s);


            // Печатаем цветным, выбор цвета остается за нами 
            Printer printerGreen = new PrinterColor(ConsoleColor.Green);
            printerGreen.Print(s);

            // Печатаем цветным, выбор цвета остается за нами 
            PrinterColor printerDarkMagenta = new PrinterColor(ConsoleColor.DarkMagenta);
            printerDarkMagenta.Print(s);


            // Delay.
            Console.ReadKey();
        }
    }
}
