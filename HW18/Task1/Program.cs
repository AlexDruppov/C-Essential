using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");

            
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine($"Total number: {dictionary.Count}");
            Console.WriteLine($"Key 3: {dictionary[3]}");


            Console.ReadKey();
        }
    }
}
