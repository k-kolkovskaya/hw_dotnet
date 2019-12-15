using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte @sbyte = 12;
            SByte @SByte = 13;
            Console.WriteLine($"{@sbyte} {@SByte}");

            short @short = 12;
            Int16 @Int16 = 12;
            Console.WriteLine($"{@short} {@Int16}");

            int @int = 12;
            Int32 @Int32 = 12;
            Console.WriteLine($"{@int} {@Int32}");

            long @long = 123;
            Int64 @Int64 = 123;
            Console.WriteLine($"{@long} {@Int64}");

            byte @byte = 121;
            Byte @Byte = 123;
            Console.WriteLine($"{@byte} {@Byte}");

            ushort @ushort = 12;
            UInt16 @UInt16 = 12;
            Console.WriteLine($"{@ushort} {@UInt16}");

            char @char = '1';
            Char @Char = '1';
            Console.WriteLine($"{@char} {@Char}");

            uint @uint = 4565454;
            UInt32 @UInt32 = 4546454;
            Console.WriteLine($"{@uint} {@UInt32}");

            ulong @ulong = 455654547;
            UInt64 @UInt64 = 5454678979;
            Console.WriteLine($"{@ulong} {@UInt64}");

            float @float = 45;
            Single @Single = 456;
            Console.WriteLine($"{@float} {@Single}");

            double @double = 4.5;
            Double @Double = 4.56;
            Console.WriteLine($"{@double} {@Double}");

            decimal @decimal = 45454;
            Decimal @Decimal = 456546;
            Console.WriteLine($"{@decimal} {@Decimal}");

            string @string = "Hello";
            String @String = "Hello";
            Console.WriteLine($"{@string} {@String}");

            object @object = 1;
            Object @Object = 1;
            Console.WriteLine($"{@object} {@Object}");

        }
    }
}
