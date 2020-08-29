using System;

namespace SSSPAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphSSSP graph = new GraphSSSP(10);
            graph.AddEdgeUnDirected(0, 8);
            graph.AddEdgeUnDirected(8, 2);
            graph.AddEdgeUnDirected(8, 9);
            graph.AddEdgeUnDirected(2, 1);
            graph.AddEdgeUnDirected(9, 1);
            graph.AddEdgeUnDirected(2, 4);
            graph.AddEdgeUnDirected(1, 3);
            graph.AddEdgeUnDirected(1, 7);
            graph.AddEdgeUnDirected(3, 4);
            graph.AddEdgeUnDirected(3, 5);
            graph.AddEdgeUnDirected(7, 6);
            graph.AddEdgeUnDirected(5, 6);
            graph.SSSPWithBFS(0);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
