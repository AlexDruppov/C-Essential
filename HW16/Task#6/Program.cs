using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            _3D p1 = new _3D(1, 3, 5);
            _3D p2 = new _3D(7, 9, 11);

            _3D sum = p1 + p2;
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
