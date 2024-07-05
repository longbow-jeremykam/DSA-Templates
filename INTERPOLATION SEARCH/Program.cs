using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERPOLATION_SEARCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interpolation Search ***********************************
            //REQUIRES SORTING
            //Best used for "UNIFORMLY" distrbuted data
            //Complexity: usually O(log(log(N))), but in worst case will be O(N) (values increase exponentially)

            //Search guesses where a value might be based on calculated probes results
            //if probe is incorrect, search area is narrowed
            //REPEAT ...until target is found

            //int[] array = { 1,2,4,8,16,32,64,128,256,512,1024 };
            int[] array = { 1,2,3,4,5,6,7,8,9};

            int index = interpolateSearch(array, 256);

            if (index != 1)
            {
                Console.WriteLine("Element found at no." + index);
            }
            else
            {
                Console.WriteLine("Element not found!");
            }

            Console.ReadKey();
        }

        public static int interpolateSearch(int[] array, int value)
        {
            int high = array.Length - 1;

            int low = 0;

            while (value >= array[low] && value <= array[high] && low <= high) 
            {
                int probe = low + (high - low) * (value - array[low]) / (array[high] - array[low]);

                Console.WriteLine("probe: " + probe);

                if (array[probe] == value)
                {
                    return probe;
                }
                else if (array[probe] < value)
                {
                    low = probe + 1;
                }
                else
                {
                    high = probe - 1;
                }
            }

            return -1;
        }
    }
}
