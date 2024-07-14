using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            House original = new House(5, 12);

            House originalClone = original.Clone();

            House deepClone = original.DeepClone();

            //deepClone.Width = 25;
            //deepClone.Height = 10;
            original.Width = 50;


            Console.WriteLine($"House original - Height: {original.Height}, Width: {original.Width}");
            Console.WriteLine($"House originalClone - Height: {originalClone.Height}, Width: {originalClone.Width}");
            Console.WriteLine($"House deepClone - Height: {deepClone.Height}, Width: {deepClone.Width}");

            Console.ReadKey();
        }
    }
}
