using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            DocumentWorker document;

            if (key == "pro")
            {
                document = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                document = new ExpertDocumentWorker();
            }
            else
            {
                document = new DocumentWorker();
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadLine();

        }
    }
}
