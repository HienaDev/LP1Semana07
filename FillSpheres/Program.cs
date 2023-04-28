using System;

namespace FillSpheres
{
    

    
    class Program
    {
        static void Main(string[] args)
        {
            Color colorRed = new Color (255, 0, 0);
            Color colorGreen = new Color (0, 255, 0);

            Sphere redBall = new Sphere(colorRed, 5f);
            Sphere greenBall = new Sphere(colorGreen, 2f);

            Console.WriteLine($"Red Ball was thrown {redBall.GetTimesThrown()} times with color ({colorRed.GetRed()}, {colorRed.GetGreen()}, {colorRed.GetBlue()}, {colorRed.GetAlpha()})");
            redBall.Throw();
            Console.WriteLine($"Red Ball was thrown {redBall.GetTimesThrown()} times with color ({colorRed.GetRed()}, {colorRed.GetGreen()}, {colorRed.GetBlue()}, {colorRed.GetAlpha()})");
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.GetRed()}, {colorGreen.GetGreen()}, {colorGreen.GetBlue()}, {colorGreen.GetAlpha()})");
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.GetRed()}, {colorGreen.GetGreen()}, {colorGreen.GetBlue()}, {colorGreen.GetAlpha()})");
            greenBall.Pop();
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.GetTimesThrown()} times with color ({colorGreen.GetRed()}, {colorGreen.GetGreen()}, {colorGreen.GetBlue()}, {colorGreen.GetAlpha()})");
        }
    }
}
