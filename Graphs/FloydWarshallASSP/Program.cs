using System;

namespace FloydWarshallASSP
{
    class Program
    {
        static void Main(string[] args)
        {
            FWGraph graph = new FWGraph(4);
            graph.AddWeightedEdge(1, 4, 1);// Add A-> D , weight 1
            graph.AddWeightedEdge(1, 2, 8);// Add A-> B , weight 8
            graph.AddWeightedEdge(2, 3, 1);// Add B-> C , weight 1
            graph.AddWeightedEdge(3, 1, 4);// Add C-> A , weight 4
            graph.AddWeightedEdge(4, 2, 2);// Add D-> B , weight 2
            graph.AddWeightedEdge(4, 3, 9);// Add D-> C , weight 9
            graph.FWAssp();
            Console.ReadKey();
        }
    }
}
