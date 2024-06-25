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
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Mustang");
            dictionary.Add(2, "Chelenger");
            dictionary.Add(3, "Viper");
            dictionary.Add(4, "Corvet");

            for (int i = 0; i < dictionary.Count; i++)
            {
                int key = dictionary.GetKey(i);
                string value = dictionary.GetValue(i);
                Console.WriteLine($"Key: {key}, Car: {value}");
            }

            Console.WriteLine($"All number {dictionary.Count}");

            dictionary.Clear();
            Console.WriteLine($"All number {dictionary.Count}");

            Console.ReadKey();
        }
    }
}
