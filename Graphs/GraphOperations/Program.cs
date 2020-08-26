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
            graph.AddEdgeUndirected(0, 1);
            graph.AddEdgeUndirected(0, 2);
            graph.AddEdgeUndirected(1, 2);
            graph.AddEdgeUndirected(2, 0);
            graph.AddEdgeUndirected(2, 3);
            graph.AddEdgeUndirected(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            graph.BFS(2);
            Console.ReadKey();
        }
    }
}
