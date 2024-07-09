//Switched to .NET 6.0 as .NET Framework does not support the data structure

//Priority Queue *********************************
//FIFO data structure
//Elements with the highest priority is served first
//before elements with lower priority

using System.Diagnostics;

PriorityQueue<String, String> queue = new PriorityQueue<String, String>();

queue.Enqueue("B", "B");
queue.Enqueue("C", "C");
queue.Enqueue("A", "A");
queue.Enqueue("F", "F");
queue.Enqueue("D", "D");

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

Console.ReadKey();