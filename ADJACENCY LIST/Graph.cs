using System;
using System.Collections.Generic;
using System.Linq;

public class Graph
{
	List<LinkedList<Node>> adjList;

	public Graph()
	{
		adjList = new List<LinkedList<Node>>();
	}

	public void addNode(Node node)
	{
		LinkedList<Node> currentList = new LinkedList<Node>();

		currentList.AddLast(node);

		adjList.Add(currentList);
	}

	public void addEdge(int src, int dst)
	{
		//more steps to improve readability
		LinkedList<Node> selectedHeadList = adjList[src];

		LinkedList<Node> nodeToConnect = adjList[dst];

		Node dstNode = nodeToConnect.ElementAt(0);

        selectedHeadList.AddLast(dstNode);
	}

	public bool checkEdge(int src, int dst)
	{
		LinkedList<Node> tempList = adjList[src];
		Node dstNode = adjList[dst].ElementAt(0);

		foreach (Node node in tempList)
		{
			if (node == dstNode)
			{
				return true;
			}
		}

		return false;
	}

	public void print()
	{
		foreach (LinkedList<Node> currentList in adjList)
		{
			foreach (Node node in currentList)
			{
				Console.Write(node.Data + " -> ");
			}

			Console.WriteLine();

		}
    }
}
