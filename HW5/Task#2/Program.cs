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
            int x = 10;
            int[] box = new int[x];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                box[i] = random.Next(1, 20);
            }

            int max = box[0];
            int min = box[0];
            foreach (int i in box)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;

            }

            int sum = 0;
            foreach (int i in box)
            {
                sum = sum + i;
            }
            double numder = sum / x;

            Console.WriteLine($"Max number is {max}");
            Console.WriteLine($"Min number is {min}");
            Console.WriteLine($"All numbers - {sum}");
            Console.WriteLine($"Middle number {numder}");

            Console.WriteLine("Odd numbers");
            foreach (int i in box)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }

            Console.ReadKey();

        }
    }
}