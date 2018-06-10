using System;
namespace Task_3_v2
{
    #region Hometask_02_3_v2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Требуется:
    // Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле 
    // и метод void Show(). Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    // Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            string content = "This new edition of Pro C# 5.0 and the .NET 4.5 Platform" +
            "\n has been completely revised and rewritten to reflect the latest changes" +
            "\n to the C# language specification and new advances in the .NET Framework.";
            Book book = new Book("Pro C# 5.0 and the .NET 4.5 Framework, 6th edition", "Andrew Troelsen", content);
            book.Show();
            // Delay.
            Console.ReadKey();
        }
    }
}
