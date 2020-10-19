using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingBigNumbers
{
    public class Util
    {
        public static string Add(string one, string two)
        {
            
            string newStringLeft = "";
            string newStringRight = "";
            string final = "";

            if (two.Length > one.Length)
            {
                string temp = one;
                one = two;
                two = temp;
            }
            Dictionary<int, int> SOne = new Dictionary<int, int>();
            Dictionary<int, int> STwo = new Dictionary<int, int>();
            Dictionary<int, int> SFinal = new Dictionary<int, int>();

            for (int i = 0; i < one.Length - two.Length; i++)
            {
                SOne.Add(i, int.Parse(one[i].ToString()));
                STwo.Add(i, 0);
                newStringLeft += one[i];
            }
            int twoCounter = 0;
            for (int i = one.Length - two.Length; i < one.Length; i++)
            {
                SOne.Add(i, int.Parse(one[i].ToString()));
                STwo.Add(i, int.Parse(two[twoCounter].ToString()));
                twoCounter++;
                newStringRight += one[i];
            }
            for (int i = 0; i < one.Length; i++)
            {
                int result = SOne[i] + STwo[i];
                SFinal.Add(i, result);
            }
            for (int i = SFinal.Count - 1; i >= 0 ; i--)
            {
                if (SFinal[i] > 9 & i != 0)
                {
                    SFinal[i - 1] += 1;
                    SFinal[i] -= 10;
                }
            }
            for (int i = 0; i < SFinal.Count; i++)
            {
                final += SFinal[i];
            }
            return final;
        }
    }

}
