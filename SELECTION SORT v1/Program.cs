using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECTION_SORT_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Sort ********************************
            //Searches through an array and find the minimum value during each iteration
            //At the end, the variables compared are swapped
            //Time complexity - O(N²) / Space complexity - O(1)

            int[] array = { 7, 4, 2, 6, 9, 1, 3, 5, 8 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                //minimum value
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    //replace the sign with > for DESCENDING order
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                //if the minimum number is not at index i yet
                if (min != i)
                {
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }

            foreach (int i in array)
            {
                Console.WriteLine($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
