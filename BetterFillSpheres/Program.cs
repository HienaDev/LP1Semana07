using System;

namespace BetterFillSpheres
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

        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }

        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }

        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }

        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }


        public byte Grey
        {
            get
            {
                return (byte)((red + green + blue) / 3);
            }
        }
    }

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
    class Program
    {
        static void Main(string[] args)
        {
            Color colorRed = new Color (255, 0, 0);
            Color colorGreen = new Color (0, 255, 0);

            Sphere redBall = new Sphere(colorRed, 5f);
            Sphere greenBall = new Sphere(colorGreen, 2f);

            Console.WriteLine($"Red Ball was thrown {redBall.GetTimesThrown()} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Grey}");
            redBall.Throw();
            Console.WriteLine($"Red Ball was thrown {redBall.GetTimesThrown()} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Grey}");
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
            greenBall.Pop();
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Grey}");
        }
    }
}
