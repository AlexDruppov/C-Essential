using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                Console.WriteLine("Enter first number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("Add - 1");
                Console.WriteLine("Subtract - 2");
                Console.WriteLine("Multiply - 3");
                Console.WriteLine("Divide - 4");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {calculator.Sub(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {calculator.Mul(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result: {calculator.Div(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
