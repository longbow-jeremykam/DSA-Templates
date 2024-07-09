﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Graph
{
	List<Node> nodes;
	int[,] matrix;

	public Graph(int size)
	{
		nodes = new List<Node>();
		matrix = new int[size, size];
    }

	public void addNode(Node node)
	{
		nodes.Add(node);
	}

	public void addEdge(int src, int dst)
	{
		matrix[src, dst] = 1;
    }

    public Boolean checkEdge(int src, int dst)
	{
		if (matrix[src, dst] != 1)
		{
			return false;
		}

		return true;
	}

	public void print()
	{
        Console.Write("  ");
		foreach (Node node in nodes)
		{
            Console.Write(node.Data + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
		{
            Console.Write(nodes[i].Data + " ");

            for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i, j] + " ");
			}
			Console.WriteLine();
		}
	}

	public void breadthFirstSearch(int src)
	{
		Queue<int> queue = new Queue<int>();

		bool[] visited = new bool[matrix.Length];

		queue.Enqueue(src);
		visited[src] = true;

		while (queue.Count > 0)
		{
			src = queue.Dequeue();
			Console.WriteLine(nodes.ElementAt(src).Data + " = visited");

			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				if (matrix[src, i] == 1 && !visited[i])
				{
					queue.Enqueue(i);
					visited[i] = true;
				}
			}
        }
	}
}