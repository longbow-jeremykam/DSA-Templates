using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADJACENCY_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adjacency List **********************************
            //An array or list that has a unique node as the head
            //All adjacent nodes are added as references to the node's LinkedList
            //
            //Time complexity - O(N) / Space complexity - O(N + B),
            //where N as number of nodes while B as number of relationships
            //***************************************************

            Graph graph = new Graph();

            //add nodes
            graph.addNode(new Node('A'));
            graph.addNode(new Node('B'));
            graph.addNode(new Node('C'));
            graph.addNode(new Node('D'));
            graph.addNode(new Node('E'));

            //add relationships between nodes
            graph.addEdge(0, 1);
            graph.addEdge(1, 2);
            graph.addEdge(1, 4);
            graph.addEdge(2, 3);
            graph.addEdge(2, 4);
            graph.addEdge(4, 0);
            graph.addEdge(4, 2);

            //print the adjacency list
            graph.print();

            //check whether relationship exists
            Console.WriteLine(graph.checkEdge(0, 1));

            Console.ReadKey();
        }
    }
}
