using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "This new edition of Pro C# 5.0 and the .NET 4.5 Platform" +
            "\n has been completely revised and rewritten to reflect the latest changes" +
            "\n to the C# language specification and new advances in the .NET Framework.";

            string title = "Pro C# 5.0 and the .NET 4.5 Framework, 6th edition";

            string author = "Andrew Troelsen";

            Book book = new Book();

            book.AddTitle(title);
            book.AddAuthor(author);
            book.AddContent(content);

            book.Show();

            Console.ReadKey();
        }
    }
}
