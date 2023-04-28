using System;

namespace FillSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public byte GetRed() => red;

        public void SetRed(byte red)
        {
            this.red = red;
        }

        public byte GetGreen() => green;

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public byte GetBlue() => blue;

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetAlpha() => alpha;

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public byte GetGrey() => (byte)((red + green + blue) / 3);
    }

    public class Sphere
    {
        private Color color;
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
