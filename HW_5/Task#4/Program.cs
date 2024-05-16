using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(4);

            store[0] = new Article("Book", "Ebooks", 500);
            store[1] = new Article("Phone", "EPhone", 50000);
            store[1] = new Article("Cup", "Ecup", 50);

            Console.WriteLine("Enter index");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                store.ArticleInfo(index);
            }
            else
            {
                Console.WriteLine("Wrong index.");
            }

            Console.ReadKey();
        }
    }
}
