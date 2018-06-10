using System;
namespace Task_3_v2
{
    class Book
    {
        readonly Title title;
        readonly Author author;
        readonly Content content;

        internal Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        internal void Show()
        {
            title.Show();
            author.Show();
            content.Show();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
