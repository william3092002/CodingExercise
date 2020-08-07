using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an integer number: ");
            string input0 = Console.ReadLine();
            int input = int.Parse(input0);
            squareOrNot(input);
            
            
        }

        private static bool squareOrNot(int input)
        {
            double num = Math.Sqrt(input);
            if (input < 0)
            {
                Console.WriteLine("negative numbers aren't square numbers");
                return false;  
            }
            if (num % 1.0 == 0)
            {
                Console.WriteLine($"{input} is a square number");
                return true;
            }                
            else
            {
                Console.WriteLine($"{input} isn't a square number");
                return false;
            }
                
        }   

    }
}
