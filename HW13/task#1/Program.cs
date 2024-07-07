using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;           
            Console.ForegroundColor = ConsoleColor.White;

            Random random = new Random();

            while (true)
            {
                int length = random.Next(1, 20);
                var value = (char)random.Next(33, 127);
                int x = random.Next(Console.WindowWidth);

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(x, i);

                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(value);
                    }
                    else if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(value);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(value);
                    }

                    Thread.Sleep(50); 
                }
            }
        }
    }
}