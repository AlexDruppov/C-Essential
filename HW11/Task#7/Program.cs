using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = "Hello";
            var myBox1 = MyClass.FactoryMethod(box1);
            Console.WriteLine(myBox1);

            var box2 = 6;
            var myBox2 = MyClass.FactoryMethod(box2);
            Console.WriteLine(myBox2);

            Console.ReadKey();
        }
    }
}
