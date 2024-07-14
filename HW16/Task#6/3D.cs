using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class _3D
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public _3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static _3D operator +(_3D p1, _3D p2)
        {
            return new _3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
        
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
