using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Divisors(1234564421))
            {
                Console.Write($"[{item}]");
            }
        }
        public static int[] Divisors(int n)
        {
            List<int> dividers = new List<int>();

            Console.WriteLine(Math.Sqrt(n));
            for (int i = 2; i <= Math.Sqrt(n) ; i++)
            {
                if (n%i==0)
                {
                    if (i != Math.Sqrt(n))
                    {
                        dividers.Add(i);
                    }

                    dividers.Add(n / i);
                }
            }
            if (dividers.Count == 0)
                return null;

            int[] arrayDivisors = dividers.ToArray();
            Array.Sort(arrayDivisors);
            return arrayDivisors;
        }
    }
   
}
