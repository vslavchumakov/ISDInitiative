using System;
namespace Task_3_v2
{
    class Content
    {
        readonly string content;
        internal Content(string content)
        {
            this.content = content;
        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Content: " + content);
        }
    }
}