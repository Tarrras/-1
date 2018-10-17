using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public struct Points3D
    {
        public double X;
        public double Y;
        public double Z;
        public Points3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public struct Points2D
    {
        public int X;
        public int Y;
        public Points2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Pair
    {
        public int A;
        public int B;
        public Pair(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
