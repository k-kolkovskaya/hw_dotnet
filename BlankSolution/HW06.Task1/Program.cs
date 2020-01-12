using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with random members
            int[] arrayRandom = new int[5];

            Random rand = new Random();

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rand.Next(100);
                Console.Write(arrayRandom[i] + " ");
            }

            Console.WriteLine();

            //Array with members readed from console
            int[] arrayRead = new int[5];

            string selection;
            for (int i = 0; i < arrayRead.Length; i++)
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

            Console.WriteLine();

            //Array with members which are sum of previous arrays members
            int[] arraySum = new int[5];

            for (int i = 0; i < arraySum.Length;  i++)
            {
                arraySum[i] = arrayRandom[i] + arrayRead[i];
                Console.Write(arraySum[i] + " ");
            }
        }
    }
}
