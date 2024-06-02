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
            Matrix matrix = new Matrix(3,3);
            matrix.Set(0, 0, 1);
            matrix.Set(0, 1, 2);
            matrix.Set(0, 2, 3);
            matrix.Set(1, 0, 4);
            matrix.Set(1, 1, 5);
            matrix.Set(1, 2, 6);
            matrix.Set(2, 0, 7);
            matrix.Set(2, 1, 8);
            matrix.Set(2, 2, 9);

            matrix.Method();
            
            Console.ReadKey();
            
        }
    }
}
