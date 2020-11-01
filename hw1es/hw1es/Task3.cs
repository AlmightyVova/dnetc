using System;

namespace hw1es
{
    public class Book
    {
        private readonly Title _title;
        private readonly Author _author;
        private readonly Content _content;

        public Book(string title, string author, string content)
        {
            _title = new Title(title);
            _author = new Author(author);
            _content = new Content(content);
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(_title.Show);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_author.Show);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_content.Show);
        }
    }

    public class Title
    {
        public string Show { get; }


        public Title(string title)
        {
            Show = title;
        }
    }

    public class Author
    {
        public string Show { get; }


        public Author(string author)
        {
            Show = author;
        }
    }

    public class Content
    {
        public string Show { get; }


        public Content(string content)
        {
            Show = content;
        }
    }
}