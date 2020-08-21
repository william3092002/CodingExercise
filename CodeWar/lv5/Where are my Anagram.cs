using System;
using System.Collections.Generic;


namespace listAnagram
{
    class Program
    {
//using System;
//using System.Collections.Generic;

//public static class Kata
//    {
//        public static List<string> Anagrams(string word, List<string> words)
//        {
//            List<string> ret = new List<string>();
//            char[] cword = word.ToCharArray();
//            Array.Sort(cword);
//            word = new string(cword);

//            foreach (string w in words)
//            {
//                char[] wchar = w.ToCharArray();
//                Array.Sort(wchar);
//                string temp = new string(wchar);
//                if (word == temp)
//                {
//                    ret.Add(w);
//                }
//            }
//            return ret;
//        }
//    }

    static void Main(string[] args)
        {
            var words = new List<string> { "god", "cat", "ogd" };
            string word = "dog";

            var list1 = Anagrams(word, words);
            foreach (var item in list1)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }

        public static string sort(string unsortedS)
        {
            //char[] unSortCArray = unsortedS.ToCharArray();
            char[] unSortCArray = new char[unsortedS.Length];
            for (int i = 0; i < unsortedS.Length; i++)
            {
                unSortCArray[i] = unsortedS[i];
            }
            //55-59 can be done by 54

            //Array.Sort(unSortCArray);
            int startIndx = 0;
            int compIndx;
            for (startIndx = 0; startIndx < unsortedS.Length; startIndx++)
            {
                for (compIndx = startIndx + 1; compIndx < unSortCArray.Length; compIndx++)
                {
                    if (unSortCArray[compIndx] < unSortCArray[startIndx])
                    {
                        char temp = unSortCArray[startIndx];
                        unSortCArray[startIndx] = unSortCArray[compIndx];
                        unSortCArray[compIndx] = temp;
                    }
                }
            }
            //62 to 75 can be done by 61
            string sortedS = new string(unSortCArray);
            return sortedS;
        }


        public static List<string> Anagrams(string word, List<string> words)
        {
            var list1 = new List<string>();
            foreach (var item in words)
            {
                if (sort(word) == sort(item))
                    list1.Add(item);
            }
            return list1;
        }
    }
}
