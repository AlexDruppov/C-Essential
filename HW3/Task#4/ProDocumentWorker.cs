using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public override void EditDocument()
        {
            Console.WriteLine("Document is Edit");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
    }
}
