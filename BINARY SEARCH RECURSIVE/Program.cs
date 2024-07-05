using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINARY_SEARCH_RECURSIVE
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

            int[] arr = new int[] {
                9, 5, 13, 3, 8, 7, 2, 12, 6, 10, 4, 11, 1
            };

            int index = binarySearch(arr, 14, 0, arr.Length - 1);

            Console.WriteLine("index of 14: " + index);

            Console.ReadKey();
        }

        public static int binarySearch(int[] arr, int target, int l, int r)
        {
            if (target > r)
            {
                return -1;
            }

            Array.Sort(arr);

            int mid = l + (r - l) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] > target)
            {
                return binarySearch(arr, target, l, mid - 1);
            }
            else
            {
                return binarySearch(arr, target, mid + 1, r);
            }
        }
    }
}
