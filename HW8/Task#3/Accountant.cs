using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Accountant
    {
        public enum Post
        {
            Dev = 180,
            Manager = 190,
            QA = 100,
        }

        public bool AskForBonus(Post worker, int hours)
        {
            int workerHours = (int)worker;
            return hours >= workerHours;

        }
    }
}
