using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public delegate int MyDelegat(int a, int b);

    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 10; int y = 2;

            MyDelegat Add = (a, b) => { return a + b; };
            MyDelegat Sub = (a, b) => { return x - y; };
            MyDelegat Mul = (a, b) => { return x * y; };
            MyDelegat Div = (a, b) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Error");
                    return y;
                }
                else
                {
                    return x / y;
                }
                
            };
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Sub(x, y));
            Console.WriteLine(Mul(x, y));
            Console.WriteLine(Div(x, y));

            Console.ReadKey();
        }
    }
}
