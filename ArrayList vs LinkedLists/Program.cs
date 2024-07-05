using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_vs_LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this project, we are comparing the speed of linked and array lists


            LinkedList<int> linkedList = new LinkedList<int> ();

            List<int> arrayList = new List<int> ();

            long start;
            long end;
            long elapsed;

            for (int i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(i);
                arrayList.Add(i);
            }

            // ****************Linked List******************
            
            start = Stopwatch.GetTimestamp();

            //int j = linkedList.Find(0).Value;
            //int j = linkedList.Find(500000).Value;
            //int j = linkedList.Find(999999).Value;

            //linkedList.Remove(0);
            //linkedList.Remove(500000);
            linkedList.Remove(999999);

            end = Stopwatch.GetTimestamp();

            elapsed = end - start;

            Console.WriteLine("LinkedList:\t" + elapsed + " ns");

            // ****************Array List*******************

            start = Stopwatch.GetTimestamp();

            //int k = arrayList[0];
            //int k = arrayList[500000];
            //int k = arrayList[999999];

            //arrayList.Remove(0);
            //arrayList.Remove(500000);
            arrayList.Remove(999999);

            end = Stopwatch.GetTimestamp();

            elapsed = end - start;

            Console.WriteLine("ArrayList:\t" + elapsed + " ns");

            Console.ReadKey();
        }
    }
}
