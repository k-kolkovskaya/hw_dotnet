using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("This is my info message");
            Circle round1 = new Circle(10);
            Circle round2 = new Circle(2);
            Triangle triangle = new Triangle(1);

            Base[] figureObject = { round1, round2, triangle };

            foreach (Base item in figureObject)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.ToString()}. Square is {item.GetSquare()}");
            }
        }
    }
}
