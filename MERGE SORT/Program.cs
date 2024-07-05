using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERGE_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Merge Sort **********************************
            //A recursive algorithm that splits an array into subarrays until individual elements
            //A helper method will merge back the individual elements into subarrays and array that are arranged in order
            //Time complexity - O(N logN) / Space complexity - O(N)

            int[] array = { 8, 5, 2, 9, 4, 7, 6, 0, 3, 1 };

            mergeSort(array);

            foreach (int i in array)
            {
                Console.WriteLine($"{i} ");
            }

            Console.ReadKey();
        }

        public static void mergeSort(int[] array)
        {
            if (array.Length <= 1) //base case
            {
                return;
            }

            mergeRecur(array, 0, array.Length - 1); 
        }

        private static void mergeRecur(int[] array, int l, int r)
        {
            if(l >= r) { return; }

            int m = l + (r - l) / 2; //midpoint

            //recursion
            mergeRecur(array, l, m); //left array
            mergeRecur(array, m + 1, r); //right array

            mergeArr(array, l, m, r);
        }

        private static void mergeArr(int[] array, int l, int m, int r)
        {
            int leftLen = m - l + 1; //from the first element to the midpoint
            int rightLen = r - m; //from the midpoint onwards to the rightmost end

            int[] leftArr = new int[leftLen];
            int[] rightArr = new int[rightLen];

            int i, j, k; //left, right and original array indices

            //splitting into two sub-arrays
            for(i = 0; i < leftLen; i++)
            {
                leftArr[i] = array[l + i];
            }

            for (j = 0; j < rightLen; j++)
            {
                rightArr[j] = array[m + 1 + j];
            }


            for(i = 0, j = 0, k = l; k <= r; k++)
            {
                //if we have finished copying the left array
                //and if left array element is lesser or equal to the right array element
                //or our right array has finished copying over to the main array
                if (i < leftLen && (j >= rightLen || leftArr[i] <= rightArr[j]))
                {
                    array[k] = leftArr[i];
                    i++;
                }
                //else we will just copy from the right array until complete
                else
                {
                    array[k] = rightArr[j];
                    j++;
                }
            }
        }
    }
}
