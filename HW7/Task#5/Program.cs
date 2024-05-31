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
            Notebook notebook = new Notebook("Sup pro", "MakerPro", 1500);
            notebook.ShowNotebook();

            Console.ReadKey();
        }
    }
}
