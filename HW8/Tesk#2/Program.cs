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
            Console.WriteLine("Enter valee:");
            string stroka = Console.ReadLine();

            Console.WriteLine("Chose color - 1. Red, 2. Green, 3. Blue");
            int color = int.Parse(Console.ReadLine());
            
            PrintColor.Print(stroka, color);

            // Затримка, щоб консоль не закрилася відразу
            Console.ReadKey();
        }
    }
}
