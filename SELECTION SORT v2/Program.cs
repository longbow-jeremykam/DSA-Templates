using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECTION_SORT_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Sort ********************************
            //Searches through an array and find the minimum value during each iteration
            //At the end, the variables compared are swapped
            //Time complexity - O(N²) / Space complexity - O(1)

            int[] array = {7,4,2,6,9,1,3,5,8 };

            selectionSort(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static void selectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    //replace the sign with < for DESCENDING order
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
    }
}
