using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ParseInt_reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = "forty-three thousand seven hundred ninety-two";

            Console.WriteLine(ParseInt(stringNumber));

        }

        public static int ParseInt(string s)
        {
            string[] stringArray = s.Split(' ', '-');

            int thisNumber = 0;

            List<int> newList = new List<int>();
            for (int i = 0; i < stringArray.Length; i++)
            {
                parseStoNum(stringArray[i], newList);
            }

            foreach (var item in newList)
            {
                thisNumber += item;
            }
            return thisNumber;
        }
        public static void parseStoNum (string number, List<int> newList)
        {
            
            int thisNumber = 0;

            if (number.StartsWith("one") || number.StartsWith("el"))
            {
                thisNumber += 1;
                newList.Add(thisNumber);
            }
            else if(number.StartsWith("tw"))
            {
                thisNumber += 2;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("thi") || number.StartsWith("thr"))
            {
                thisNumber += 3;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("fo"))
            {
                thisNumber += 4;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("fi"))
            {
                thisNumber += 5;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("six"))
            {
                thisNumber += 6;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("sev"))
            {
                thisNumber += 7;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("eig"))
            {
                thisNumber += 8;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("nin"))
            {
                thisNumber += 9;
                    newList.Add(thisNumber);
            }
            else if (number.StartsWith("te"))
            {
                thisNumber += 10;
                newList.Add(thisNumber);
            }
            else if(number.StartsWith("hund"))
            {
                thisNumber = newList[newList.Count - 1] * 100;
                newList.RemoveAt(newList.Count - 1);
                newList.Add(thisNumber);
            }
            else if (number.StartsWith("thou"))
            {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        newList[i] *= 1000;
                    }
            }
            else if (number.StartsWith("million"))
            {
                thisNumber = newList[newList.Count - 1] * 1000000;
                newList.RemoveAt(newList.Count - 1);
                newList.Add(thisNumber);
            }
            else if (number.StartsWith("zer"))
            {
                thisNumber = 0;
                newList.Add(thisNumber);
            }
            if (number.EndsWith("leven") || number.EndsWith("lve") || number.EndsWith("een"))
            {
                thisNumber += 10;
                newList.Remove(newList[newList.Count - 1]);
                newList.Add(thisNumber);
            }
            if (number.EndsWith("ty"))
            {
                thisNumber *= 10;
                newList.Remove(newList[newList.Count - 1]);
                newList.Add(thisNumber);
            }
        }       
    }
}
