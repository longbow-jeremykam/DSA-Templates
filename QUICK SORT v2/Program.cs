using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUICK_SORT_v2
{
    internal class Program
    {
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

            //Two indices where one is the start of the array (j)
            //and another before the first element (i)
            //The element at j is compared to the pivot,
            //and the counter i will increment whenever the element at j is lesser than the pivot
            //otherwise, j will be incremented until it reaches the pivot
            //Then, the pivot will swap places with the counter i
            //Then, the elements at the left and right of the pivot will be separated
            //and the same process repeats with each side

            //Time complexity - O(N logN) (Average), 0(N²) (worst case - already sorted)
            //Space complexity - O(logN) due to recursion
            //*******************************************

            //int[] array = { 8, 5, 2, 9, 4, 7, 6, 0, 3, 1 };
            int[] array = { 10, 11, 23, 44, 7, 15, 3, 1, 12, 48, 56, 42, 81, 81 };

            quickSort(array, 0, array.Length - 1);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        private static void quickSort(int[] arr, int l, int r)
        {
            if (r <= l)
            {
                return;
            }

            int pivot = partition(arr, l, r);

            quickSort(arr, l, pivot - 1);
            quickSort(arr, pivot + 1, r);
        }

        private static int partition(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l - 1;

            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }
            i++;

            int temp2 = arr[i];
            arr[i] = arr[r];
            arr[r] = temp2;

            return i;
        }
    }
}
