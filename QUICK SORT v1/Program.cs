using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUICK_SORT_v1
{
    internal class Program
    {
        static Random random;

        static void Main(string[] args)
        {
            //Quick Sort ********************************
            //An element is chosen to be a pivot
            //either at the start, middle or most commonly, the end of the array
            //Smallers elements are moved to the left of the pivot
            //Recursively divide array into 2 partitions

            //[n] - pivot
            //  6 3 7 5 1 2 [4]
            //               |
            //       3 1 [2] 4 6 7 [5]
            //            |         |
            //          1 2 3       5 7 [6]
            //                           |
            //                           6 7
            //
            //******************************************

            int[] arr = { 10, 11, 23, 44, 7, 15, 3, 1, 12, 48, 56, 42, 81, 81 };
            //int[] arr = { 8, 5, 2, 9, 4, 7, 6, 0, 3, 1 };

            quickSort(arr);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        //Wrapper method
        public static void quickSort(int[] array)
        {
            random = new Random((int) DateTime.Now.TimeOfDay.Ticks);

            quickRecur(array, 0, array.Length - 1);
        }

        private static void quickRecur(int[] array, int low, int high)
        {
            if (high <= low) //base case
            {
                return;
            }

            //get pivot index and repeat
            int pivotIndex = partition(array, low, high);

            //recursion
            quickRecur(array, low, pivotIndex - 1); //left array
            quickRecur(array, pivotIndex + 1, high); //right array

        }

        private static int partition(int[] array, int low, int high)
        {
            int pivotIndex = low + (random.Next() % (high - low));

            if (pivotIndex != high)
            {
                int temp1 = array[pivotIndex];
                array[pivotIndex] = array[high];
                array[high] = temp1;
            }

            int pivotVal = array[high];

            int i = low;

            for(int j = low; j < high; j++)
            {
                //if the element is lesser or equal to the pivot element
                //swap element in at i and j, and increment i
                if (array[j] <= pivotVal)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;

                }
                //else increment j
            }

            int temp2 = array[i];
            array[i] = array[high];
            array[high] = temp2;

            return i;
        }
    }
}
