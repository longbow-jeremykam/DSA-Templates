using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINEAR_SEARCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear Searches *****************************************
            //Iterates through a collection one by one
            //Complexity - O(N)

            //Slower the larger the data set
            //But requires no sorting
            //Useful for data structures that do NOT facilitate RANDOM ACCESS (ex: LinkedList)
            //*********************************************************

            int[] array = { 53, 12, 86, 29, 40, 61, 94, 7, 55, 20, 88, 3, 50, 84, 67, 98, 72, 14,
                5, 45, 37, 91, 23, 62, 16, 99, 81, 11, 74, 27, 70, 35, 78, 9, 60, 26, 48, 31, 76,
                1, 33, 83, 18, 82, 10, 68, 22, 63, 80, 38, 54, 6, 96, 13, 87, 21, 56, 43, 15, 92,
                42, 97, 71, 36, 8, 64, 25, 79, 4, 47, 85, 24, 66, 46, 75, 32, 89, 19, 69, 2, 90,
                57, 49, 93, 30, 59, 39, 58, 95, 65, 44, 28, 100, 52, 17, 73, 51, 41, 77, 34};

            int index = linearSearch(array, 96);

            if (index != -1)
            {
                Console.WriteLine("Element found at no. " + index);
            }
            else
            {
                Console.WriteLine("Element not found!!!");
            }

            Console.ReadKey();
        }

        public static int linearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
