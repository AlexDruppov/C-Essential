using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public delegate double MyDelegat(int a, int b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegat myDelegat;
            myDelegat = (a, b, c) => { return (a + b + c)/3.0; };
            Console.WriteLine(myDelegat(5, 5, 6));
            Console.ReadKey();
        }
    }
}
