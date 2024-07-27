using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.FromBaseMethod();

            Console.WriteLine("__________________");

            BaseClass baseClass = new BaseClass();
            baseClass.PublicMethod();

            Console.ReadKey();
        }
    }
}
