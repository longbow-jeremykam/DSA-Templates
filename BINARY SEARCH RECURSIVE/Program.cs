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

            //int[] arr = new int[] {
            //    9, 5, 13, 3, 8, 7, 2, 12, 6, 10, 4, 11, 1
            //};

            int[] arr = new int[10000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            int index = binarySearch(arr, 3555, 0, arr.Length - 1);

            Console.WriteLine("index of 3555: " + index);

            Console.ReadKey();
        }

        public static int binarySearch(int[] arr, int target, int l, int r)
        {
            if (l > r)
            {
                return -1;
            }

            Array.Sort(arr);
            //1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13

            int mid = l + (r - l) / 2;

            Console.WriteLine("middle: " + mid);

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
