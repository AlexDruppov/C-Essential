using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(5, 6, 7, 8);

            Console.WriteLine($"block1 and block2: {block1.Equals(block2)}");

            Console.WriteLine(block1.ToString());
            Console.WriteLine(block1.GetHashCode());

            Console.WriteLine("-----------------");

            Console.WriteLine(block2.ToString());
            Console.WriteLine(block2.GetHashCode());

            Console.ReadKey();
        }
    }
}
