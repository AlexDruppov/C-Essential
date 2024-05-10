using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent studying");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent reading");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Excellent relaxing");
        }
    }
}
