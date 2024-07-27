using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
     class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new List<dynamic>
            {
                new { English = "Apple", Ukrainian = "Яблуко" },
                new { English = "House", Ukrainian = "Дім" },
                new { English = "Car", Ukrainian = "Машина" },
                new { English = "Book", Ukrainian = "Книга" },
                new { English = "Tree", Ukrainian = "Дерево" },
                new { English = "Dog", Ukrainian = "Собака" },
                new { English = "Cat", Ukrainian = "Кіт" },
                new { English = "Water", Ukrainian = "Вода" },
                new { English = "Food", Ukrainian = "Їжа" },
                new { English = "Computer", Ukrainian = "Комп'ютер" }
            };

            Console.WriteLine("English-Ukrainian Dictionary:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.English} - {item.Ukrainian}");
            }

            Console.ReadKey();
        }
    }
}
