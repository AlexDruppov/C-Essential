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
            Accountant accountant = new Accountant();

            Console.WriteLine("Enter position");
            string workerInput = Console.ReadLine();

            if (Enum.TryParse(workerInput, true, out Accountant.Post worker))
            {
                Console.WriteLine("Enter hours:");
                if (int.TryParse(Console.ReadLine(), out int hours))
                {
                    bool bonus = accountant.AskForBonus(worker, hours);

                    if (bonus)
                    {
                        Console.WriteLine("Good job!!!");
                    }
                    else
                    {
                        Console.WriteLine("Bad work. Very bad work!!!");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

