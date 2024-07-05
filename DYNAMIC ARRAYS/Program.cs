using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Arrays **********************************
            //Does not have a fixed size
            //Same properties as a static array (0(n) for iteration, insertion and deletion)
            //Resizes according to how many elements in array

            
            DynamicArray dynamicArray = new DynamicArray(5);

            dynamicArray.Add("A");
            dynamicArray.Add("B");
            dynamicArray.Add("C");
            dynamicArray.Add("D");
            dynamicArray.Add("E");
            dynamicArray.Add("F");

            dynamicArray.Delete("A");
            dynamicArray.Delete("B");
            dynamicArray.Delete("C");
            //dynamicArray.Insert(0, "X");
            //dynamicArray.Delete("A");
            //Console.WriteLine(dynamicArray.Search("C"));

            Console.WriteLine(dynamicArray.ToString());
            Console.WriteLine("size:" + dynamicArray.Size);
            Console.WriteLine("capacity:" + dynamicArray.Capacity);
            Console.WriteLine("empty:" + dynamicArray.isEmpty());

            Console.ReadKey();
        }
    }
}
