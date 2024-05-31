using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    struct Notebook
    {
        private string _model;
        private string _maker;
        private int _coust;

        public Notebook(string model, string maker, int coust)
        {
            _model = model;
            _maker = maker;
            _coust = coust;
        }

        public void ShowNotebook()
        {
            Console.WriteLine($"The {_model} from the {_maker} costs {_coust}");
        }
    }
}
