using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRead = new int[5];

            string selection;
            for (int i = 0; i < arrayRead.Length - 1; i++)
            {
                Console.WriteLine("Enter integer");
                selection = Console.ReadLine();
                if (!Int32.TryParse(selection, out arrayRead[i]))
                {
                    Console.WriteLine("That's not integer!!! Enter integer, please!");
                    i--;
                }
            }

            for (int i = 0; i < arrayRead.Length; i++)
            {
                Console.Write(arrayRead[i] + " ");
            }

            Console.WriteLine("Enter another one integer");
            int number = Int32.Parse(Console.ReadLine());
            int index = Int32.Parse(Console.ReadLine());

            if (index < arrayRead.Length)
            {
                for (int i = arrayRead.Length - 2; i >= index; i--)
                {
                    arrayRead[i + 1] = arrayRead[i];
                }

                arrayRead[index] = number;

                for (int i = 0; i < arrayRead.Length; i++)
                {
                    Console.Write(arrayRead[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("You should enter value that is not bigger than array length!");
            }

            

            Console.ReadLine();
        }
    }
}
