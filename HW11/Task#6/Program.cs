using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();

            // Добавление элементов структурного и ссылочного типов
            list.Add(new MyStruct(1));
            list.Add(new MyStruct(2));
            list.Add(new MyClass("Hello"));
            list.Add(new MyClass("World"));

            // Перебор элементов коллекции с помощью цикла for
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {list[i]}");
            }


            Console.ReadKey();
        }
    }
}
