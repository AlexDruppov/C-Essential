using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            int numberOfChains = 10;
            Random random = new Random();

            for (int i = 0; i < numberOfChains; i++)
            {
                new Thread(() =>
                {
                    while (true)
                    {
                        int length = random.Next(5, 15);
                        int x = random.Next(Console.WindowWidth);
                        char value = (char)random.Next(33, 127);

                        for (int j = 0; j < length; j++)
                        {
                            Console.SetCursorPosition(x, j);

                            if (j == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (j == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }

                            Console.Write(value);
                            value = (char)random.Next(33, 127);

                            Thread.Sleep(50); 
                        }
                    }
                }).Start();
            }

            Console.ReadKey();
        }
    }   
}

