using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open Doc");
        }
        public override void Create()
        {
            Console.WriteLine("Create Doc");
        }
        public override void Change()
        {
            Console.WriteLine("Change Doc");
        }
        public override void Save()
        {
            Console.WriteLine("Save Doc");
        }
    }
}
