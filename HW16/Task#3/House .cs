using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class House
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public House(int height, int width) 
        {
            Height = height;
            Width = width;
        }

        public House Clone()
        {
            return this.MemberwiseClone() as House;
        }

        public House DeepClone() 
        {
            return new House(Height, Width);
        }
    }
}
