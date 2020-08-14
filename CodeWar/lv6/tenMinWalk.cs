using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenMinWalk
{
    class Program
    {

        //You live in the city of Cartesia where all roads are laid out in a perfect grid.
        //You arrived ten minutes too early to an appointment, so you decided to take the opportunity 
        //to go for a short walk.The city provides its citizens with a Walk Generating App 
        //on their phones -- everytime you press the button it sends you an array of 
        //one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). 
        //You always walk only a single block for each letter (direction) and you know it takes you 
        //one minute to traverse one city block, so create a function that will return true 
        //if the walk the app gives you will take you exactly ten minutes 
        //(you don't want to be early or late!) and will, of course, 
        //return you to your starting point. Return false otherwise.
        static void Main(string[] args)
        {
            string[] walk = { "w", "e", "w", "e", "w", "e"};
            bool makeItOrNot = isValidWalk(walk);
            Console.WriteLine(makeItOrNot);
        }

        public static bool isValidWalk(string[] walk)
        {
            int vertical = 0;
            int horizontal = 0; 
            for (int i = 0; i < walk.Length; i++)
            {
                switch(walk[i])
                {
                    case "e":
                        horizontal++;
                        break;
                    case "w":
                        horizontal--;
                        break;
                    case "n":
                        vertical++;
                        break;
                    case "s":
                        vertical--;
                        break;
                }
                
            }
            if (walk.Length == 10 && vertical == 0 && horizontal == 0)
                return true;
            else
                return false;
               

        }
    }
}
