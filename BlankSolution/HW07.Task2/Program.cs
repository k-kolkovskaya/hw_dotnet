using System;
using System.Text;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "But I must is simply dummy text of the printing and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown";
            //RemoveLongest(text);
            //GetShortest(text);
            //ChangeWords(text);
            SortArray(text);
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

        static void ChangeWords(string text)
        {
            StringBuilder modifiedString = new StringBuilder(text);
            string shortest = GetShortest(text);
            string longest = GetLongest(text);
            Console.WriteLine("This words will be changed: " + longest + " " + shortest);
            Console.WriteLine(modifiedString.Replace(longest, shortest));
            text = modifiedString.Replace(shortest, longest).ToString();
            Console.WriteLine(text);
        }

        static void SortArray(string text)
        {
            string[] arrayOfWords = text.Split(" ");
            StringBuilder modifiedString = new StringBuilder(text);

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                string longest = GetLongest(modifiedString.ToString());
                arrayOfWords[i] = longest;
                
                if(string.IsNullOrEmpty(modifiedString.ToString()) == false)
                {
                    modifiedString.Replace(longest, "");
                }
                else
                {
                    break;
                }             

                Console.WriteLine(arrayOfWords[i]);
            }
        }
    }
}
