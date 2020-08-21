using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascolS_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = 9;
            int row = 7;
            pascalTriangle(numOfRows, row);
        }
        private static void pascalTriangle(int n, int row)
        {
            int column = 1;
            int[][] items;
            items = new int[n][];
            
            for (int outerLCounter = 0; outerLCounter < n; outerLCounter++)
            {
                items[outerLCounter] = new int[outerLCounter + 1];
                for (int innerCounter = 0; innerCounter < column; innerCounter++)
                {
                    if (innerCounter == 0 | innerCounter == column - 1)
                    {
                        items[outerLCounter][innerCounter] = 1;
                    }
                    else
                    {
                        items[outerLCounter][innerCounter] = items[outerLCounter - 1][innerCounter] + items[outerLCounter - 1][innerCounter - 1];
                    }
                    Console.Write($"[{items[outerLCounter][innerCounter]}]");
                }
                column++;
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var item in items[row-1])
            {
                Console.Write($"[{item}]");
            }
        }
    }
}
