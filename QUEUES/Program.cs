using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue *************************************************
            //FIFO (FIRST-IN, FIRST-OUT) linear data structure
            //A collection to hold elements before processing
            //Ex: The waiting line at the checkout counter

            /*
             * To add to queue,
             *      .enqueue()
            // Adds an element at the tail of the queue
             
             * To remove from queue,
             *      .dequeue()
             */
            // Removes an element at the head of the queue
            //*******************************************************

            Queue<String> queue = new Queue<String>();
            
            queue.Enqueue("Karen");
            queue.Enqueue("Chad");
            queue.Enqueue("Steve");
            queue.Enqueue("Harold");

            //pop() to remove from the top,
            //it also returns the element value which can be assigned to a variable
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Peek();

            //peek() to return the topmost element without removing it
            //Console.WriteLine(queue.Peek());

            //printing the queue through foreach loop
            foreach (string item in queue)
            {
                Console.Write(item + " ");
            }

            //.Count will return the number of elements in the queue
            //Console.WriteLine(queue.Count);

            //Contains() to determine whether queue contains element
            //Console.WriteLine(queue.Contains("Harold"));

            //USES OF QUEUES
            /*
             * 1. Keyboard buffer (letters should appear on the screen according to the order they're pressed)
             * 2. Print Queue
             * 3. Found also in LinkedLists, PriorityQueues, BFS (breadth-first search)
             */

            Console.ReadKey();
        }
    }
}
