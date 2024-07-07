using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");

            Console.WriteLine("MyDictionary elements:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine($"Total number of elements: {dictionary.Count}");
            Console.WriteLine($"Element with key 3: {dictionary[3]}");

            Console.ReadKey();
        }
    }
}
