using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public virtual void EditDocument() 
        {
            Console.WriteLine("Edit Document only for Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Save Document only for Pro version");
        }
    }
}
