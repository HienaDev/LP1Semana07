using System;

namespace BetterFillSpheres
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public float Grey
        {
            get
            {
                return ((Red + Green + Blue) / 3f);
            }
        }
    }

    public class Sphere
    {
        private Color Color { get; }
        public float Radius { get; set; }
        public int ThrowTimes { get; set; } = 0;

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
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
    class Program
    {
        static void Main(string[] args)
        {
            Color colorRed = new Color (255, 0, 0);
            Color colorGreen = new Color (0, 255, 0);

            Sphere redBall = new Sphere(colorRed, 5f);
            Sphere greenBall = new Sphere(colorGreen, 2f);

            Console.WriteLine($"Red Ball was thrown {redBall.ThrowTimes} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Grey}");
            redBall.Throw();
            Console.WriteLine($"Red Ball was thrown {redBall.ThrowTimes} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Grey}");
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
            greenBall.Pop();
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
        }
    }
}
