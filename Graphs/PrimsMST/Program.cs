using System;
using System.Collections.Generic;

namespace PrimsMST
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimsGraph graph = new PrimsGraph(5);
            graph.AddWeightedEdgeUndirected(1, 2, 10);
            graph.AddWeightedEdgeUndirected(1, 3, 20);
            graph.AddWeightedEdgeUndirected(2, 3, 30);
            graph.AddWeightedEdgeUndirected(2, 4, 5);
            graph.AddWeightedEdgeUndirected(3, 4, 15);
            graph.AddWeightedEdgeUndirected(3, 5, 6);
            graph.AddWeightedEdgeUndirected(4, 5, 8);

            graph.PrimsMST(4);
            Console.ReadKey();
        }
    }
}
