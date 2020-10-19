using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop_spinning_my_words
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numStr = { 2, 5, 6, 114, 21, 325, 120, 54, 1, 3, 8, 9 };
            int c = 0;
            foreach (var item in numStr.Reverse().ToArray())
            {
                Console.Write(item);
                if(c < numStr.Length-1)
                    Console.Write(", ");
                c++;
            }
            Console.WriteLine();


            //int x = 0;
            //foreach (var item in greeting.Reverse().ToArray())
            //{
            //    Console.Write(item);
            //    if (c < newNumStr.Length - 1)
            //        Console.Write(", ");
            //    x++;
            //}
            //Console.WriteLine();

            string greeting = "welcome I am William and Hello";
            string[] words = greeting.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    Console.Write(words[i].Reverse().ToArray());
                        if (i < words.Length - 1)
                            Console.Write(" ");
                }
                else
                {
                    Console.Write(words[i]);
                        if (i < words.Length - 1)
                            Console.Write(" ");
                }
            }
            Console.WriteLine();
            //string result = spinWords(greeting);
            //Console.WriteLine(result);
        }
        private static string spinWords(string greeting)
        {
            int fSpace = 0;
            int sSpace = 0;
            char[] newString = new char[greeting.Length];
            for (int totalCharCount = 0; totalCharCount <= greeting.Length -1; totalCharCount++)
            {
                if (greeting[totalCharCount] == ' ' & fSpace == 0)
                {
                    fSpace = totalCharCount;
                    if (fSpace >= 5)
                    {
                        int endIndx = fSpace - 1;
                        for (int i = 0; i < fSpace; i++)
                        {
                            newString[i] = greeting[endIndx];
                            endIndx--;
                        }
                    }
                }
                if (greeting[totalCharCount] == ' ' & fSpace != totalCharCount)
                {
                    sSpace = totalCharCount;
                    int wordLength = sSpace - 1 - fSpace;
                    if (wordLength >= 5)
                    {
                        int endIndx = sSpace - 1;
                        for (int i = fSpace + 1; i < sSpace; i++)
                        {
                            newString[i] = greeting[endIndx];
                            endIndx--;
                        }
                    }
                    fSpace = sSpace;
                }
                if (totalCharCount == greeting.Length -1)
                {
                    int wordLength = totalCharCount - sSpace;
                    if (wordLength >= 5)
                    {
                        int endIndx = totalCharCount;
                        if (fSpace == 0)
                            sSpace -= 1;
                        for (int i = sSpace + 1; i <= totalCharCount; i++)
                        {
                            newString[i] = greeting[endIndx];
                            endIndx--;
                        }
                    }
                    if(wordLength < 5)
                        newString[totalCharCount] = greeting[totalCharCount];
                }
                else
                    newString[totalCharCount] = greeting[totalCharCount];
            }
            string result = new string(newString);
            return result;
        }
    }
}
