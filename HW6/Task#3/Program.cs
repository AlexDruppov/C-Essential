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
            Book book = new Book();
            book.FindNext("Program");

            Book.Notes notes = new Book.Notes();
            notes.SaveNotes("book");

            Console.ReadKey();
        }
    }
}
