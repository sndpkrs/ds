using System;

namespace KruskalMST
{
    class Program
    {
        static void Main(string[] args)
        {
            MSTGraph graph = new MSTGraph(5);
            graph.AddWeightedEdgeUndirected(1, 2, 10);
            graph.AddWeightedEdgeUndirected(1, 3, 20);
            graph.AddWeightedEdgeUndirected(2, 3, 30);
            graph.AddWeightedEdgeUndirected(2, 4, 5);
            graph.AddWeightedEdgeUndirected(3, 4, 15);
            graph.AddWeightedEdgeUndirected(3, 5, 6);
            graph.AddWeightedEdgeUndirected(4, 5, 8);
            Console.WriteLine(graph.MinimumCost() + "is the minimum cost");
            Console.ReadKey();
        }
    }
}
