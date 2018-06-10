using System;
namespace Task_3_v2
{
    class Title
    {
        readonly string title;
        internal Title(string title)
        {
            this.title = title;
        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Title: " + title);
        }
    }
}