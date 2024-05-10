using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good studying");
        }

        public override void Read()
        {
            Console.WriteLine("Good reading");
        }

        public override void Write()
        {
            Console.WriteLine("Good writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Good relaxing");
        }
    }
}
