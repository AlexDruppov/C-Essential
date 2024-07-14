using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Block
    {
        public int A;
        public int B;
        public int C;
        public int D;

        public Block(int a, int b, int c, int d) 
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Block other = (Block)obj;

            return (A == other.A) && (B == other.B) && (C == other.C) && (D == other.D);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C, D);
        }

        public override string ToString()
        {
            return $"Block: {A}, {B}, {C}, {D}" ;
        }
    }
}
