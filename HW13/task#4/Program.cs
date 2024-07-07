using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            int maxDepth = 5;
            Method(0, maxDepth);

            Console.ReadKey();
        }

        static void Method(int depth, int maxDepth)
        {
            if (depth > maxDepth) return;

            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Thread {depth} started.");
                Thread.Sleep(1000);

                Method(depth + 1, maxDepth);
                Console.WriteLine($"Thread {depth} finished.");
            });

            thread.Start();
            thread.Join();
        }
    }
}
