using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5


{
    internal class Printer
    {
       
        public void Print(string value)
        {
            var random = new Random();
            var colors = Enum.GetValues(typeof(ConsoleColor));
            var randomColor = (ConsoleColor)colors.GetValue(random.Next(colors.Length));

            Console.ForegroundColor = randomColor;
            Console.WriteLine(value);
            Console.ResetColor();

        }
        
    }
}
