using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DOCHandler doc = new DOCHandler();
            TXTHandler txt = new TXTHandler();
            XMLHandler xml = new XMLHandler();

            doc.Open();
            txt.Open();
            xml.Open();

           Console.ReadKey();
            
        }
    }
}
