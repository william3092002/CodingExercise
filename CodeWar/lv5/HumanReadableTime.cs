using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(2458));
        }

        public static string GetReadableTime(int totalSeconds)
        {
            //use string.Format
            //return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);

            //use TimeSpan.FromSeconds
            //var t = TimeSpan.FromSeconds(seconds);
            //return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);

            string humanReadableTime; 
            
            string secString;
            int sec = totalSeconds % 60;
            if (sec < 10)
                secString = $"0{sec}";
            else
                secString = sec.ToString();

            string minString;
            int min = (totalSeconds / 60) % 60;
            if (min < 10)
                minString = $"0{min}";
            else
                minString = min.ToString();

            string hourString;
            int hour = totalSeconds / 60 / 60;
            if (hour < 10)
                hourString = $"0{hour}";
            else
                hourString = hour.ToString();

            humanReadableTime = ($"{hourString}:{minString}:{secString}");

            return humanReadableTime;

        }


    }
}
