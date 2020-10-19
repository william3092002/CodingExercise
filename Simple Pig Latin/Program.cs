using System;
using System.Text;
namespace Simple_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Pig latin is cool!!";
            Console.WriteLine(PigIt(originalString));
        }
        //public static string PigIt2(string str)
        //{
        //    var words = str.Split(' ');
        //    var sb = new StringBuilder();
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        sb.Append(words[i].Substring(1));
        //        sb.Append(words[i][0]);
        //        sb.Append("ay ");
        //    }

        //    return sb.ToString().TrimEnd(' ');
        //}
        public static string PigIt(string originalString)
        {
            string sortedString = "";
            string tempS = "";
            for (int i = 0; i < originalString.Length; i++)
            {
                if (char.IsLetter(originalString[i]))
                    tempS += originalString[i];
                if (!char.IsLetter(originalString[i]) | i == originalString.Length-1)
                {
                    if (tempS != "")
                    {
                        sortedString += shift(tempS);
                        tempS = "";
                    }
                    if (!char.IsLetter(originalString[i]))
                        sortedString += originalString[i];
                }
            }
            return sortedString;
        }
        public static string shift(string a)
        {
            int startIndx = 1;
            char[] newString = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newString[i] = a[startIndx];
                startIndx++;
                if (startIndx == a.Length)
                    startIndx = 0;
            }
            string shiftedString = new string(newString) + "ay";
            return shiftedString;
        }
    }
}
