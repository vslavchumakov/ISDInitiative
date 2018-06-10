using System;
namespace Task_3_v2
{
    class Author
    {
        readonly string name;
        internal Author(string name)
        {
            this.name = name;
        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Author: " + name);
        }
    }
}