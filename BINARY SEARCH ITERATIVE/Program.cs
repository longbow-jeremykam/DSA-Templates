using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BINARY_SEARCH_ITERATIVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary Search *************************************************
            //REQUIRES SORTING

            //Search for target from the midpoint of the dataset
            //Splits the dataset into half
            //If the target value is lower, then it will search the first half and disregard the second half and vice versa if the opposite case
            //REPEAT! ...until target value is found
            //***************************************************************

            int[] arr = new int[10000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            //int index = Array.BinarySearch(arr, 3555);
            int index = binarySearch(arr, 3555);

            if (index == -1)
            {
                Console.WriteLine(index + " not found!");
            }
            else
            {
                Console.WriteLine("Target found at: " + index);
            }

            Console.ReadKey();
        }

        public static int binarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int middle = low + (high - low) / 2;
                int value = arr[middle];

                Console.WriteLine("middle: " + middle);

                if (value < target)
                {
                    low = middle + 1;
                }else if (value > target)
                {
                    high = middle - 1;
                }
                else
                {
                    return middle;
                    //target found
                }
            }

            return -1;
            //target not found
        }
    }
}
