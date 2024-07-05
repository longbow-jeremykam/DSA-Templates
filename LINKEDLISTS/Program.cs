using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKEDLISTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linked Lists ******************************
            //Difference from arrays:
            //Consisted of nodes, the nodes contain the data and address for the next node
            //Does not have an index system
            //0(1) for insertion and deletion (better than array & arraylists),
            //but 0(n) for iteration through nodes (no random access, arrays are faster)

            //Two types: Doubly (default) & Singly LinkedList
            LinkedList<String> list = new LinkedList<String>();

            //Adding from the head of the list
            list.AddFirst("A");
            list.AddFirst("B");
            list.AddFirst("C");
            list.AddFirst("D");
            list.AddFirst("F");

            //RemoveFirst() - Removes first node of the list
            //list.RemoveFirst();

            //AddAfter() to add after a new node after certain node
            //list.AddAfter(list.Find("D"), "E");

            //Remove() to remove if list contains node
            //list.Remove("E");

            //Contains() to determine whether list contains node
            Console.WriteLine(list.Contains("A"));

            //printing the linked list through foreach loop
            foreach (String item in list)
            {
                Console.WriteLine(item);
            }

            //USES OF LINKEDLISTS
            /*
             * 1. Can be used to implement Stacks/Queues (NOT SUPPORTED IN C#)
             * 2. GPS Navigation
             * 3. Music playlists
             */

            Console.ReadKey();
        }
    }
}
