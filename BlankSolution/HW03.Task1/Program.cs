using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //1.1.
            byte a = 13;
            ushort b = a;

            //1.2.
            ushort c = 75;
            long d = c;

            //1.3.
            byte e = 4;
            int f = e + 70; //ok, cause the result of the sum is integer

            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);

            //2.
            //2.1.
            int g = 568;
            byte h = (byte)g;

            //2.2.
            long i = 87;
            ushort j = (ushort)i;

            //2.3.
            byte k = 4;
            byte l = (byte)(k + 70); //not ok, cause the result of the sum is integer, so we need to explicitly convert it to byte

            Console.WriteLine(j);
            Console.WriteLine(h);
            Console.WriteLine(l);

            //3.
            //3.1.
            int val = 5;
            object obj = val;

            //3.2.
            byte val1 = 23;
            object obj1 = val1;

            //3.3.
            long val2 = 23;
            object obj2 = val2 + 13;

            Console.WriteLine(obj);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //4.
            //4.1.
            int valUnboxed = (int)obj;

            //4.2.
            byte valUnboxed1 = (byte)obj1;

            //4.3.
            long valUnboxed2 = (long)obj2;

            Console.WriteLine(valUnboxed);
            Console.WriteLine(valUnboxed1);
            Console.WriteLine(valUnboxed2);
        }
    }
}
