using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new ExcellentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new GoodPupil();

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            classRoom.ShowClassInfo();

            Console.ReadKey();
        }
    }
}
