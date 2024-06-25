using System;
using System.Collections;
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
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Mustang");
            arrayList.Add("Challenger");
            arrayList.Add("Viper");
            arrayList.Add("Corvette");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"Element at index {i}: {arrayList[i]}");
            }

            Console.WriteLine($"All number {arrayList.Count}");

            arrayList.Clear();
            Console.WriteLine($"All number {arrayList.Count}");

            Console.ReadKey();

        }
    }
}
