using System;
using GraphNode;

namespace GraphOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphAdjacencyList graph = new GraphAdjacencyList(5);
            graph.PrintGraph();
            graph.AddEdgeDirected(0, 1);
            graph.AddEdgeDirected(0, 2);
            graph.AddEdgeDirected(1, 2);
            graph.AddEdgeDirected(2, 0);
            graph.AddEdgeDirected(2, 3);
            graph.AddEdgeDirected(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            graph.BFS(2);
            graph.DFS(2);
            Console.WriteLine("-----------------------------------------------------");
            GraphAdjacencyList g = new GraphAdjacencyList(6);
            g.AddEdgeDirected(5, 2);
            g.AddEdgeDirected(5, 0);
            g.AddEdgeDirected(4, 0);
            g.AddEdgeDirected(4, 1);
            g.AddEdgeDirected(2, 3);
            g.AddEdgeDirected(3, 1);
            g.TopologicalSort();
            Console.ReadKey();
        }
    }
}
