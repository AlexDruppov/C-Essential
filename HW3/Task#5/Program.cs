using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            printer.Print("Test");
            class1.Print("test");
            class2.Print("test");

            Console.ReadKey();
        }
    }
}
