using System;
using System.Collections.Generic;
using System.Linq;


namespace Backspaces_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString = CleanString("ABC#-#DE@$F");
            Console.WriteLine(sampleString);
        }
        public static string CleanString(string s)
        {
            List<char> listString = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '#')
                    listString.Add(s[i]);
                if (s[i] == '#')
                {
                    if(listString.Count()!=0)
                        listString.RemoveAt(listString.Count() - 1);
                }
                    
            }
            char[] charArray = listString.ToArray();
            string newString = new string(charArray);
            return newString;
        }
    }

}
