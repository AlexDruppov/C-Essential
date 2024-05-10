using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[4];

            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }

        public void ShowClassInfo()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");
                if (pupils[i] != null)
                {
                    Console.WriteLine("Study:");
                    pupils[i].Study();
                    Console.WriteLine("Read:");
                    pupils[i].Read();
                    Console.WriteLine("Write:");
                    pupils[i].Write();
                    Console.WriteLine("Relax:");
                    pupils[i].Relax();
                }
            }
        }
    }
}
