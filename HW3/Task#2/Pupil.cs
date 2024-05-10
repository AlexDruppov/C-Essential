using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is studying.");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil is reading.");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil is writing.");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relaxing.");
        }
    }
}
