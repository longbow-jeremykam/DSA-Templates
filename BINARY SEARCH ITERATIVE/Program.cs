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

            int[] arr = new int[92] {
                894567,432156,765432,234567,789012,654321,876543,123456,567890,432198,890123,
                345678,765432,234567,987654,876543,543210,654321,890123,456789,210987,789012,
                987654,543210,876543,321098,456789,876543,234567,543210,765432,654321,890123,
                421378,837215,554982,923736,765412,216543,348957,673412,123456,876543,567890,
                324567,890123,432198,987654,345678,210987,876543,543210,987654,234567,789012,
                654321,876543,123456,567890,432198,890123,345678,765432,234567,987654,876543,
                543210,654321,890123,456789,210987,789012,987654,543210,876543,321098,456789,
                876543,234567,543210,765432,654321,890123,456789,321098,234567,543210,765432,
                654321,890123,456789,321098
            };

            Array.Sort(arr);

            //int index = Array.BinarySearch(arr, 876543);
            int index = binarySearch(arr, 876543);

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
