using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float radius;
        private int throwTimes;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            throwTimes = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
                throwTimes++;
        }

        public int GetTimesThrown() => throwTimes;

    }
}