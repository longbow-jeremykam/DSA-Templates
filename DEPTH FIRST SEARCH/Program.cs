using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPTH_FIRST_SEARCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Depth First Search ***************************************
            //An algorithm for traversing a tree or graph branch by branch
            //Uses the Stack data structure
            //Pick a route and keep going
            //If you reach a dead end or visit a visited node,
            //backtrack to the previous node with unvisited adjacent neighbors

            //*Children are visited before siblings*
            //**********************************************************

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
            Console.WriteLine(graph.checkEdge(3, 2));

            graph.depthFirstSearch(3);

            Console.ReadKey();
        }
    }
}
