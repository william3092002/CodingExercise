using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string addedBinary = addBinary(41616, 32780);
            Console.WriteLine(addedBinary);
        }

        //Implement a function that adds two numbers together and returns their sum in binary.
        //The conversion can be done before, or after the addition.
        //The binary number returned should be a string.

        public static string addBinary(int a, int b)
        {
            int sum = a + b;
            ulong result = 0;
            int remainder = 0;
            int n = 0;

            do
            {
                remainder = sum % 2;
                result += (ulong)(remainder * Math.Pow(10, n));
                sum /= 2;
                n++;

            }
            while (sum != 0);
            return result.ToString();
        }
        //public static string addBinary(int a, int b)
        //{
        //    return Convert.ToString(a + b, 2);
        //}

    }
}
