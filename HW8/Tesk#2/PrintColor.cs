using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class PrintColor
    {
        enum Colors
        {
            Red = 1,
            Green = 2,
            Blue = 3
        }
        public static void Print(string stroka, int color)
        {
            ConsoleColor consoleColor = ConsoleColor.White; ;

            switch ((Colors)color)
            {
                case Colors.Red:
                    consoleColor = ConsoleColor.Red;
                    break;
                case Colors.Green: 
                    consoleColor = ConsoleColor.Green;
                    break;
                case Colors.Blue:
                    consoleColor = ConsoleColor.Blue;
                    break;
            }
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(stroka);
            Console.ResetColor();

        }
    }
}
