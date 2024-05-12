using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Create TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Create TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Create TXT");
        }
    }
}
