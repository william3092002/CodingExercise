using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace listAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "ab";
            var listOfStrings = new List<string>() { "asb", "Ba", "bsdac" };

            var newList = new List<string>();
            newList = Anagrams(testString, listOfStrings);
            
            foreach (var item in newList)
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
            }
            Console.WriteLine();

        }
        //The method receives a single string(sample) and a list of strings. 
        //The method will retrun any string that is an anagram of the sample string.
        
        public static List<string> Anagrams(string word, List<string> words)
        {
            // I add all the numeric values of the character in the string and compare them.
            // If they're identical, they're anagram.

            //Generate a new list to store the strings that is anagram to my sameple string.
            var newList = new List<string>();

            //Use a for loop to iterate thorugh each characters in the sample word,
            //get the sum(totTests) of numeric value for my sample word.
            int totTestS = 0;
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                totTestS += word[i];
            }

            //use a for loop to iterate through each word in my words list. 
            for (int i = 0; i < words.Count(); i++)
            {
                
                words[i] = words[i].ToLower();
                //if the length of the sameple word and the 'i'th element in my list are different,
                //ommit the rest of my code and give control back to line 57.
                if (word.Length != words[i].Length)
                {
                    continue;
                }
                //declare and reset the numerica value of the 'i'th element to 0.
                int totSampleS = 0;
                //for loop iterate through the characters of the 'i'th element, concatnate each value to
                //get a sum.
                for (int c = 0; c < words[i].Length; c++)
                {
                    totSampleS += words[i][c];
                }
                //compare the sum values between the sample word and the 'i'th element in words list,
                //if they're identical, the 'i'th element is an anagram, add it to the new list.  
                if (totTestS == totSampleS)
                {
                    newList.Add(words[i]);
                }
            }
            return newList;

            //This is another method where I compare and remove the words that are not anagrams 
            //using the same ASCII sum compare concept. 

            //var newList = new List<string>();
            //int totTestS = 0;
            //word = word.ToLower();
            //for (int i = 0; i < word.Length; i++)
            //{
            //    totTestS += word[i];
            //}
            //for (int i = 0; i < words.Count(); i++)
            //{
            //    words[i] = words[i].ToLower();
            //    if (word.Length != words[i].Length)
            //    {
            //        words.RemoveAt(i);
            //        i--;
            //        continue;
            //    }
            //    int totSampleS = 0;
            //    for (int c = 0; c < words[i].Length; c++)
            //    {
            //        totSampleS += words[i][c];
            //    }
            //    if (totTestS != totSampleS)
            //    {
            //        words.RemoveAt(i);
            //        i--;
            //    }
            //    else
            //    {
            //        newList.Add(words[i]);
            //    }
            //}
            //return newList;
        }

    }

}
