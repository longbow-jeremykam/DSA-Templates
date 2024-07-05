using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADJACENCY_MATRIX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adjacency Matrix **********************************
            //A 2D array that stores 1s and 0s
            // n rows and columns = number of unique nodes
            //Time complexity - O(1) / Space complexity - O(N²) where N = number of nodes/vertices
            //***************************************************

            Graph graph = new Graph(5);

            //add nodes
            graph.addNode(new Node('A'));
            graph.addNode(new Node('B'));
            graph.addNode(new Node('C'));
            graph.addNode(new Node('D'));
            graph.addNode(new Node('E'));

            //add relationships between nodes
            graph.addEdge(0, 1);
            graph.addEdge(1, 2);
            graph.addEdge(2, 3);
            graph.addEdge(2, 4);
            graph.addEdge(4, 0);
            graph.addEdge(4, 2);

            //print the adjacency matrix
            graph.print();

            //check whether relationship exists
            Console.WriteLine(graph.checkEdge(3,2));

            Console.ReadKey();
        }
    }
}
