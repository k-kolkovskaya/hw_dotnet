using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"{typeof(Program).Namespace} starts");
            Circle round1 = new Circle(10);
            Logger.Log.Info("New instance of Circle was created");
            Square square = new Square(2);
            Logger.Log.Info("New instance of Square was created");
            Triangle triangle = new Triangle(1);
            Logger.Log.Info("New instance of Triangle was created");

            Base[] figureObject = { round1, square, triangle };

            Logger.Log.Info("Output to console starts");
            foreach (Base item in figureObject)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.ToString()}. Square is {item.GetSquare()}");
            }

            Logger.Log.Info($"{typeof(Program).Namespace} finishes");
        }
    }
}
