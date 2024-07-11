using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    struct Worker
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int JobYear { get; set; }

        public Worker(string name, string job, int jobYear)
        {
            Name = name;
            Job = job;
            JobYear = jobYear;
        }

        public int WorkYear()
        {
            return DateTime.Now.Year - JobYear;
        }

    }
}
