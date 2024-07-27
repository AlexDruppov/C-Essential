using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            dynamic a = 10;
            dynamic b = 5;

            Console.WriteLine("Add: " + calculator.Add(a, b));
            Console.WriteLine("Sub: " + calculator.Sub(a, b));
            Console.WriteLine("Mul: " + calculator.Mul(a, b));
            Console.WriteLine("Div: " + calculator.Div(a, b));

            Console.ReadKey();
        }
    }
}
