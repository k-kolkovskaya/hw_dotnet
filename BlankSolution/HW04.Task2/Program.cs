using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press some W-S-A-D button");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "W":
                case "w":
                    Console.WriteLine("Turn up!");
                    break;
                case "A":
                case "a":
                    Console.WriteLine("Turn left!");
                    break;
                case "S":
                case "s":
                    Console.WriteLine("Turn down!");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("Turn right!");
                    break;
                default:
                    Console.WriteLine("Don't move!");
                    break;
            }
        }
    }
}
