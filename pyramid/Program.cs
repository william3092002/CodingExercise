using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //int x1 = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    int n = 3;
            //    int x = 1;
            //    if (i == 4)
            //        Console.Write("#");
            //    else
            //        Console.Write("$");
            //    n -= a;
            //    while (n > 0)
            //    {
            //        Console.Write("$");
            //        n--;
            //    }
            //    a++;
            //    x += x1;
            //    while (x > 0)
            //    {
            //        if (x > 4)
            //        {
            //            x = 4;
            //        }
            //        Console.Write("#");
            //        x--;
            //    }
            //    x1++;
            //    Console.Write("\n");
            //}
            //string strnum = Console.ReadLine();
            //int num = int.Parse(strnum);
            //int n = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("#");

            //    int j = 0;
            //    while (j < n)
            //    { 
            //        Console.Write("#");
            //        j++;
            //    }
            //    Console.Write("\n");
            //    n++;
            //}
            //int arg;
            //doIncrement(out arg);

            //Console.WriteLine(arg); // writes 42, not 43 

            int a = 0;
            int x1 = 0;
            for (int i = 0; i < 5; i++)
            {
                int n = 3;
                int x = 1;
                if (i == 4)
                    Console.Write("");
                else
                    Console.Write(" ");
                n -= a;
                while (n > 0)
                {
                    Console.Write(" ");
                    n--;
                }
                a++;
                x += x1;
                while (x > 0)
                {
                    Console.Write("#");
                    x--;
                }
                x1++;
                Console.Write("\n");
            }

        }
        static void doIncrement(out int param)
        {
            param = 9;
        }
    }
}
