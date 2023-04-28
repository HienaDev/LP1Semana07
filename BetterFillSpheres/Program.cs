using System;

namespace BetterFillSpheres
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Color colorRed = new Color (255, 0, 0);
            Color colorGreen = new Color (0, 255, 0);

            Sphere redBall = new Sphere(colorRed, 5f);
            Sphere greenBall = new Sphere(colorGreen, 2f);

            Console.WriteLine($"Red Ball was thrown {redBall.ThrowTimes} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Greyscale}");
            redBall.Throw();
            Console.WriteLine($"Red Ball was thrown {redBall.ThrowTimes} times with color ({colorRed.Red}, {colorRed.Green}, {colorRed.Blue}, {colorRed.Alpha}) and Grey value: {colorRed.Greyscale}");
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Greyscale}");
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Greyscale}");
            greenBall.Pop();
            greenBall.Throw();
            Console.WriteLine($"Green Ball was thrown {greenBall.ThrowTimes} times with color ({colorGreen.Red}, {colorGreen.Green}, {colorGreen.Blue}, {colorGreen.Alpha}) and Grey value: {colorGreen.Greyscale}");
            Console.WriteLine($"Green Ball name: {Color.Name(greenBall.Color)}");
            Console.WriteLine($"Red Ball name: {Color.Name(redBall.Color)}");
        }
    }
}
