using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] squareArray =
            //    {
            //    new[]{1,2,3},
            //    new[]{8,9,4},
            //    new[]{7,6,5}
            //    };
            //int[][] squareArray =
            //    {
            //    new[]{1,2,3,4},
            //    new[]{12,13,14,5},
            //    new[]{11,16,15,6},
            //    new[]{10,9,8,7}
            //    };

            //int[][] squareArray =
            //{
            //    new[]{1,2,3},
            //    new[]{10,11,4},
            //    new[]{9,12,5},
            //    new[]{8,7,6}
            //};

            //int[][] squareArray =
            //   {
            //    new[]{1,2,3,4,5},
            //    new[]{16,17,18,19,6},
            //    new[]{15,24,25,20,7},
            //    new[]{14,23,22,21,8},
            //    new[]{13,12,11,10,9}
            //    };

            //int[][] squareArray =
            //    {
            //    new[]{1,2,3,4,5,6},
            //    new[]{20,21,22,23,24,7},
            //    new[]{19,32,33,34,25,8},
            //    new[]{18,31,36,35,26,9},
            //    new[]{17,30,29,28,27,10},
            //    new[]{16,15,14,13,12,11}
            //    };

            int[][] squareArray =
               {
                new[]{1,2,3,4,5,6,7},
                new[]{24,25,26,27,28,29,8},
                new[]{23,40,41,42,43,30,9},
                new[]{22,39,48,49,44,31,10},
                new[]{21,38,47,46,45,32,11},
                new[]{20,37,36,35,34,33,12},
                new[]{19,18,17,16,15,14,13}
                };

            int[] snailArray = Snail(squareArray);
            foreach (var item in snailArray)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] Snail(int[][] squareArray)
        {
            int counter = 0;
            int width = squareArray[0].Length;
            int height = squareArray.Length;
            int[] sortedArray = new int[width*height];
            int sortRow = 0;
            int sortColumn = 0;
            while (width != 0 || height != 0)
            {
                for (int i = 0; i < width; i++)
                {
                    sortedArray[counter] = squareArray[sortRow][sortColumn];
                    counter++;
                    sortColumn++;
                }
                sortColumn--;
                if (height > 0)
                    height--;
                for (int i = 0; i < height; i++)
                {
                    sortRow++;
                    sortedArray[counter] = squareArray[sortRow][sortColumn];
                    counter++;
                }
                if (width > 0)
                    width--;
                for (int i = 0; i < width; i++)
                {
                    if (sortColumn > 0)
                        sortColumn--;
                    sortedArray[counter] = squareArray[sortRow][sortColumn];
                    counter++;
                }
                if (height > 0)
                    height--;
                sortRow--;
                for (int i = 0; i < height; i++)
                {
                    sortedArray[counter] = squareArray[sortRow][sortColumn];
                    counter++;
                    if (height >= 1)
                        sortRow--;
                }
                if (width > 0)
                    width--;
                sortColumn++;
                sortRow++;
            }
            return sortedArray;
        }
        //public static int[] Snail(int[][] array)
        //{
        //    int l = array[0].Length;
        //    int[] sorted = new int[l * l];
        //    Snail(array, -1, 0, 1, 0, l, 0, sorted);
        //    return sorted;
        //}

        //public static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        //{
        //    if (l == 0)
        //        return;
        //    for (int j = 0; j < l; j++)
        //    {
        //        x += dx;
        //        y += dy;
        //        sorted[i++] = array[y][x];
        //    }
        //    Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        //}
    }
}
