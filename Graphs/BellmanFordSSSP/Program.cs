using System;

namespace BellmanFordSSSP
{
    class Program
    {
        static void Main(string[] args)
        {
            BellmanFordGraph graph = new BellmanFordGraph(5);
            graph.AddWeightedEdgeDirected(1, 3, 6); //Add A-> C , weight 6
            graph.AddWeightedEdgeDirected(2, 1, 3); //Add B-> A , weight 3
            graph.AddWeightedEdgeDirected(1, 4, -6); //Add A-> D , weight 6
            graph.AddWeightedEdgeDirected(4, 3, 1); //Add D-> C , weight 1
            graph.AddWeightedEdgeDirected(3, 4, 2); //Add C-> D , weight 2
            graph.AddWeightedEdgeDirected(4, 2, 1); //Add D-> B , weight 1
            graph.AddWeightedEdgeDirected(5, 4, 2); //Add E-> D , weight 2
            graph.AddWeightedEdgeDirected(5, 2, 4); //Add E-> B , weight 4
            graph.BellmanFordSSSP(4);
            Console.ReadKey();
        }
    }
}
