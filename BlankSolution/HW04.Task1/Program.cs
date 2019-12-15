using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = '\u007A'; i >= '\u0061'; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
