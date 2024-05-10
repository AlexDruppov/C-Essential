using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad studying.");
        }

        public override void Read()
        {
            Console.WriteLine("Bad reading.");
        }

        public override void Write()
        {
            Console.WriteLine("Bad writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad relaxing");
        }
    }
}
