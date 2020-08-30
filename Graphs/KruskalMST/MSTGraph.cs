using DisjointSetLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace KruskalMST
{
    public class MSTGraph
    {
        public int NoOfNodes;
        public List<Node> Nodelist;
        public List<UndirectedEdge> edges;
        public MSTGraph(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            Nodelist = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                Nodelist.Add(new Node(i));
            }
            edges = new List<UndirectedEdge>();
        }
        public void AddWeightedEdgeUndirected(int fromIndex, int toIndex, int weight)
        {
            var fromNode = Nodelist.Find(e => e.Index == fromIndex - 1);
            var toNode = Nodelist.Find(e => e.Index == toIndex - 1);
            edges.Add(new UndirectedEdge(fromNode, toNode, weight));
            fromNode.Neighbours.AddLast(toNode);
            toNode.Neighbours.AddLast(fromNode);
            fromNode.NeighboursWeightedMap.Add(toNode, weight);
            toNode.NeighboursWeightedMap.Add(fromNode, weight);
        }

        public int MinimumCost()
        {
            int cost = 0;
            DSet set = new DSet(0);
            set.MakeSet(Nodelist);

            edges.Sort();
            foreach (var edge in edges)
            {
                var firstNode = edge.First;
                var secondNode = edge.Second;
                if(set.FindSet(firstNode) != set.FindSet(secondNode))
                {
                    set.Union(firstNode, secondNode);
                    cost = cost + edge.Weight;
                }
            }
            return cost;
        }
    }
}
