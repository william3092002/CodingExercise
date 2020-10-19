using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("      ...---... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-  "));

        }
        public static string Decode(string morseCode)
        {
            Dictionary<string, char> morseCodeDictionary = new Dictionary<string, char>()
            {
                { ".-", 'a'},
                { "-...", 'b'},
                { "-.-.", 'c'},
                { "-..", 'd'},
                { ".", 'e'},
                { "..-.", 'f'},
                { "--.", 'g'},
                { "....", 'h'},
                { "..", 'i'},
                { ".---", 'j'},
                { "-.-", 'k'},
                { ".-..", 'l'},
                { "--", 'm'},
                { "-.", 'n'},
                { "---", 'o'},
                { ".--.", 'p'},
                { "--.-", 'q'},
                { ".-.", 'r'},
                { "...", 's'},
                { "-", 't'},
                { "..-", 'u'},
                { "...-", 'v'},
                { ".--", 'w'},
                { "-..-", 'x'},
                { "-.--", 'y'},
                { "--..", 'z'},
                { "-----", '0'},
                { ".----", '1'},
                { "..---", '2'},
                { "...--", '3'},
                { "....-", '4'},
                { ".....", '5'},
                { "-....", '6'},
                { "--...", '7'},
                { "---..", '8'},
                { "----.", '9'},
                { "", ' '},
                { "-.-.--", '!' },
                { ".-.-.-", '.' }
            };
            string[] morseCodeArray = morseCode.Split();
            List<string> words = new List<string>();
            for (int i = 0; i < morseCodeArray.Count(); i++)
            {
                if (morseCodeDictionary.ContainsKey(morseCodeArray[i]))
                {
                    words.Add(morseCodeDictionary[morseCodeArray[i]].ToString());
                    if (i != 0)
                        if (morseCodeArray[i] == "" & morseCodeArray[i - 1] == "")
                            words.RemoveAt(words.Count() - 1);
                }
                else if (morseCodeArray[i] == "...---...")
                    words.Add("SOS");
            }
            string[] decodedString = words.ToArray();
            StringBuilder newString = new StringBuilder();
            foreach (var item in decodedString)
            {
                newString.Append(item);
            }
            return newString.ToString().ToUpper().Trim();
        }
    }

}
