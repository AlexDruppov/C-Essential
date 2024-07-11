using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = new Worker[5];

            for (int i = 0; i < worker.Length; i++)
            {
                try
                {
                    Console.WriteLine("Enter full mame: ");
                    string fullName = Console.ReadLine();

                    Console.WriteLine("Enter job title: ");
                    string jobTitle = Console.ReadLine();

                    Console.WriteLine("Enter job start year: ");
                    int startYear = int.Parse(Console.ReadLine());
                    if (startYear < 1990)
                    {
                        throw new Exception("Wrong year");
                    }
                    worker[i] = new Worker(fullName, jobTitle, startYear);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            worker = worker.OrderBy(x => x.Name).ToArray();

            Console.WriteLine("Enter min. work years");
            int minExperience = int.Parse(Console.ReadLine());
            
            while (minExperience < 0)
            {
                Console.WriteLine("Error Experience");
            }

            Console.WriteLine($"Experience more {minExperience} years");
            foreach (var work in worker)
            {
                if (work.WorkYear() > minExperience)
                {
                    Console.WriteLine(work.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
