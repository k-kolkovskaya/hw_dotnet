using System;
using System.Text;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the poem, please! Devide lines by semicolon");
                
            string selection = Console.ReadLine();

            string[] poem = selection.Split(";");
            string[] modifiedPoem = new string[poem.Length];

            for(int i = 0; i < poem.Length; i++)
            {
                StringBuilder line = new StringBuilder(poem[i]);
                modifiedPoem[i] = line.Replace('a', 'o').Replace('A', 'O').ToString();
            }

            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(modifiedPoem[i]);
            }

            //Once upon a midnight dreary, while I pondered, weak and weary,;Over many a quaint and curious volume of forgotten lore—;While I nodded, nearly napping, suddenly there came a tapping,;As of some one gently rapping, rapping at my chamber door.;
        }
    }
}
