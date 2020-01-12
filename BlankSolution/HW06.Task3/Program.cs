using System;
using System.Diagnostics;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < (arr.Length - 1)/2; i++)
            {
                int firstValue = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = firstValue;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            //Testing
            long[] testArr = new long[1000000000];

            Random rand = new Random();

            for (int i = 0; i < testArr.Length; i++)
            {
                testArr[i] = rand.Next(1000000000);
            }

            Stopwatch reverse = new Stopwatch();

            reverse.Start();
            for (int i = 0; i < (testArr.Length - 1) / 2; i++)
            {
                long firstValue = testArr[i];
                testArr[i] = testArr[testArr.Length - 1 - i];
                testArr[testArr.Length - 1 - i] = firstValue;
            }
            reverse.Stop();
            TimeSpan ts = reverse.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
