using System;
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
            int x = 5;
            int y = 10;

            Console.WriteLine($"{Calculator.Add(x, y)}");
            Console.WriteLine($"{Calculator.Subtraction(x, y)}");
            Console.WriteLine($"{Calculator.Multiply(x, y)}");
            Console.WriteLine($"{Calculator.Divide(x, y)}");

            Console.ReadKey();
        }
    }
}
