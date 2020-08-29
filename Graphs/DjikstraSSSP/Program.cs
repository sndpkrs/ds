using System;

namespace DjikstraSSSP
{
    class Program
    {
        static void Main(string[] args)
        {
            DjikstraGraph graph = new DjikstraGraph(5);
            graph.AddWeightedEdge(1, 3, 6); //Add A-> C , weight 6
            graph.AddWeightedEdge(1, 4, 3); //Add A-> D , weight 3
            graph.AddWeightedEdge(2, 1, 3); //Add B-> A , weight 3
            graph.AddWeightedEdge(3, 4, 2); //Add C-> D , weight 2
            graph.AddWeightedEdge(4, 3, 1); //Add D-> C , weight 1
            graph.AddWeightedEdge(4, 2, 1); //Add D-> B , weight 1
            graph.AddWeightedEdge(5, 2, 4); //Add E-> B , weight 4
            graph.AddWeightedEdge(5, 4, 2); //Add E-> D , weight 2
            graph.DjikstraSSSP(4);
            Console.ReadKey();
        }
    }
}
