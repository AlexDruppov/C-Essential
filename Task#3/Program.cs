using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть назву книги:");
            string title = Console.ReadLine();

            Console.WriteLine("Введіть автора книги:");
            string author = Console.ReadLine();

            Console.WriteLine("Введіть опис книги:");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            book.Show();
            Console.ReadKey();
        }
    }

    class Title
    {
        string _title;

        public Title(string title)
        {
            _title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Назва книги - {_title}");
        }
    }

    class Author
    {
        string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор книги - {this.author}");
        }
    }

    class Content
    {
        string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Назва книги - {this.content}");
        }
    }

    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}

