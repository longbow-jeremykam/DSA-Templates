using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSERTION_SORT_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insertion Sort *************************************
            //Compares elements to the left
            //Elements are shifted to the right to insert a value
            //Time complexity - O(N²), best at O(N) / Space complexity - O(1)

            //Better than Bubble Sort
            //Recommended to use O(N) algorithms over Selection Sort (also quadratic time)

            int[] array = { 9, 1, 8, 2, 6, 3, 7, 5, 4 };

            insertionSort(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
    }
}
