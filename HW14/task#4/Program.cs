using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("MyList elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Elements number: {list.Count}");

            int[] array = list.GetArray();
            Console.WriteLine("Elements in array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
