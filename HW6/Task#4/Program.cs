using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 6, 2, 9, 1, 4 };
            num.SortArray();
            
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
