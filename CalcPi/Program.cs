using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcPi
{
    class Program
    {
        static void Main(string[] args)
        {
            //double ENUMERATOR = 4.0;
            //int ItCounter = 0;
            //double pi = 0;
            //for (int i = 1; i < 100000; i += 2)
            //{
            //    if (ItCounter % 2 == 0)
            //        pi += Convert.ToDouble(ENUMERATOR / i);

            //    if (ItCounter % 2 != 0)
            //        pi -= Convert.ToDouble(ENUMERATOR / i);

            //    ItCounter++;
            //}
            //Console.WriteLine(pi);


            object Locker = new object();
            for (int j = 0; j < 15; j++)
            {

                Stopwatch watch = new Stopwatch();

                double PI = 0;
                double NUM = 4.0;
                int Denominator = 1;

                watch.Start();
                Parallel.For(0, 10000000, i =>
                {
                    lock (Locker)
                    {
                        PI += Convert.ToDouble(NUM / Denominator);
                        Interlocked.Add(ref Denominator, 2);
                        PI -= Convert.ToDouble(NUM / Denominator);
                        Interlocked.Add(ref Denominator, 2);
                    }
                });
                watch.Stop();

                Console.WriteLine(watch.Elapsed);
                Console.WriteLine(PI);
            }
            
        }
    }
}
