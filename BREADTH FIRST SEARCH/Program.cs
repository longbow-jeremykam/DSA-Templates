using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREADTH_FIRST_SEARCH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Breadth First Search ******************************
            //An algorithm for traversing a tree or graph level by level
            //Uses the Queue data structures
            //Find each sibling node on the same level,
            //then move on to the next level

            //*Siblings are visited before children*
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
            Console.WriteLine(graph.checkEdge(3, 2));

            graph.breadthFirstSearch(4);

            Console.ReadKey();
        }
    }
}
