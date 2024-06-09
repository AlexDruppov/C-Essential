using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    delegate int MyDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate[] myDelegate = new MyDelegate[3];
            Random random = new Random();

            myDelegate[0] = () => random.Next(1, 5);
            myDelegate[1] = () => random.Next(1, 6);
            myDelegate[2] = () => random.Next(1, 7);

            double sum = Method(myDelegate);

            Console.WriteLine(sum);

            Console.ReadLine();

        }
        static double Method(MyDelegate[] delegates)
        {
            int sum = 0;
            foreach (var num in delegates)
            {
                sum += num(); 
            }
            return (double)sum / delegates.Length;
        }
    }
}
