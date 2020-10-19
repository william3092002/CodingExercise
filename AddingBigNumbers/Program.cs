using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string one = "9999999";
           string two = "1";

            //Console.WriteLine($"{newStringLeft} + {newStringRight}" +
            //    $"\n{two}");
            //foreach (var keyValuePair in SOne)
            //{
            //    Console.WriteLine(keyValuePair);
            //}
            //foreach (var keyValuePair in STwo)
            //{
            //    Console.WriteLine(keyValuePair);
            //}
            Console.WriteLine(Util.Add(one,two));
            Console.WriteLine(long.Parse(one)+long.Parse(two));

            //string[] test = Util.BreakUpLongString(one, two);
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            //string newString = Util.Add(test[1], two);
            //string result = "";
            //long partialLeft = long.Parse(test[0]);
            //if (newString.Length != test[1].Length)
            //{
            //    partialLeft += 1;
            //    char[] finalArray = new char[test[1].Length];
            //    for (int i = 0; i < finalArray.Length; i++)
            //    {
            //        finalArray[i] = newString[i + 1];
            //    }
            //    string subFinalString = new string(finalArray);
            //    result = partialLeft.ToString() + subFinalString;
            //}
            //else
            //    result = test[0] + newString;
            //Console.WriteLine(result);

        }
    }
    
}
