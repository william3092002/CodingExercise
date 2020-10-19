using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "abcd";
            Console.WriteLine(ROT13(message));
        }
        public static string ROT13(string message)
        {
            //using System;
            //public class Kata
            //    {
            //        public static string Rot13(string message)
            //        {
            //            string result = "";
            //            foreach (var s in message)
            //            {
            //                if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
            //                    result += Convert.ToChar((s + 13)).ToString();
            //                else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
            //                    result += Convert.ToChar((s - 13)).ToString();
            //                else result += s;
            //            }
            //            return result;
            //        }
            //    }


            //return String.Join("", message.Select(x => char.IsLetter(x) ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) ? (char)(x + 13) : (char)(x - 13) : x));

            char[] messageCharArray = message.ToCharArray(); 
            
            for (int charIndx = 0; charIndx < messageCharArray.Count(); charIndx++)
            {
                if (messageCharArray[charIndx]<=90 & messageCharArray[charIndx]>=65)
                {
                    if ((messageCharArray[charIndx] +13) > 90)
                    {
                        messageCharArray[charIndx] = (char)(65 + (((int)messageCharArray[charIndx] + 13) % 91));
                    }
                    else
                        messageCharArray[charIndx] = (char)((int)messageCharArray[charIndx] + 13); 
                }
                if (messageCharArray[charIndx] <= 122 & messageCharArray[charIndx] >= 97)
                {
                    if ((messageCharArray[charIndx] + 13) > 122)
                    {
                        messageCharArray[charIndx] = (char)(97 + (((int)messageCharArray[charIndx] + 13) % 123));
                    }
                    else
                        messageCharArray[charIndx] = (char)((int)messageCharArray[charIndx] + 13);
                }
            }
            string cipherMessage = new string(messageCharArray);
            return cipherMessage;
        }
    }
}
