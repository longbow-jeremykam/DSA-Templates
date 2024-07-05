using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUBBLE_SORT_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort *********************************
            //A pair of adjacent elements are compared
            //Elements are swapped if not in order
            //Time complexity - O(N²) / Space complexity - O(1)

            int[] array = { 9, 1, 4, 6, 3, 2, 7, 5, 8 };

            bubbleSort(array);

            foreach (int i in array) 
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - i - 1); j++)
                {
                    //replace the sign with < for DESCENDING order
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[(j + 1)] = temp;
                    }
                }
            }
        }
    }
}
