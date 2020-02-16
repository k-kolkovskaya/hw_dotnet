using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("1a!2.3!!..4.!.? 6 7!.. ?");
            StringBuilder firstPart = new StringBuilder();
            StringBuilder secondPart = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] != '?')  
                {
                    firstPart.Append(text[i]);
                }
                else
                {
                    break;
                }
            }

            secondPart = text.Remove(0, firstPart.Length);
            firstPart.Replace("!", "").Replace(".", "");
            secondPart.Replace(" ", "_");
            text = firstPart.Append(secondPart);

            Console.WriteLine(text);
        }
    }
}
