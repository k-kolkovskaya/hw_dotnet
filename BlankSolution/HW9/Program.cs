using System;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greet = new Greeting();
            Airport airport = new Airport();
            greet.Greet(airport.airportName);
        }
    }
}
