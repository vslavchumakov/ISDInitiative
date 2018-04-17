using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Book
    {
        public Author Author { get; private set; }

        public Content Content { get; private set; }

        public Title Title { get; private set; }

        public Book()
        {
            Author = new Author();
            Content = new Content();
            Title = new Title();
        }

        public void AddTitle(string title)
        {
            Title.title = title;
        }

        public void AddContent(string content)
        {
            Content.content = content;
        }

        public void AddAuthor(string author)
        {
            Author.author = author;
        }

        public void Show()
        {
            Title.Show();
            Content.Show();
            Author.Show();
        }
    }
}
