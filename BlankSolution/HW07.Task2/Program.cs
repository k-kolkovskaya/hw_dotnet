using System;
using System.Text;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?";
            RemoveLongest(text);
            GetShortest(text);
        }

        static string GetLongest(string text)
        {
            string longest = "";
            string[] arrayOfWords = text.Split(" ");

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                if (arrayOfWords[i].Length > longest.Length)
                {
                    longest = arrayOfWords[i];
                }
            }
            return longest;
        }

        static string GetShortest(string text)
        {
            string shortest = GetLongest(text);
            string[] arrayOfWords = text.Split(" ");

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                if (arrayOfWords[i].Length < shortest.Length)
                {
                    shortest = arrayOfWords[i];
                    arrayOfWords[arrayOfWords.Length - 1] = shortest;
                }

                Console.WriteLine(arrayOfWords[i]);
            }
            return shortest;
        }

        static void RemoveLongest(string text)
        {
            StringBuilder modifiedString = new StringBuilder(text);
            Console.WriteLine("This word will be removed: " + GetLongest(text));
            text = modifiedString.Replace(GetLongest(text), "").ToString();
            Console.WriteLine(text);
        }
        
        static void SortArray(string text)
        {
            string[] arrayOfWords = text.Split(" ");

            for(int i = 0; i < arrayOfWords.Length; i++)
            {
                
            }
        }
    }
}
