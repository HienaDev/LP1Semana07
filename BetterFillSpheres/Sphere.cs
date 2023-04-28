using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public float Radius { get; set; }
        public int ThrowTimes { get; set; }

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            ThrowTimes = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
                ThrowTimes++;
        }


    }
}