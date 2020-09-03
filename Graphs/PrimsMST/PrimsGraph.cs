using System;
using System.Collections.Generic;
using System.Text;

namespace PrimsMST
{
    public class PrimsGraph
    {
        public int NoOfNodes;
        public List<Node> Nodelist;
        public PrimsGraph(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            Nodelist = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                Nodelist.Add(new Node(i));
            }
        }
        public void AddWeightedEdgeUndirected(int fromIndex, int toIndex, int weight)
        {
            var fromNode = Nodelist.Find(e => e.Index == fromIndex - 1);
            var toNode = Nodelist.Find(e => e.Index == toIndex - 1);
            fromNode.Neighbours.AddLast(toNode);
            toNode.Neighbours.AddLast(fromNode);
            fromNode.NeighboursWeightedMap.Add(toNode, weight);
            toNode.NeighboursWeightedMap.Add(fromNode, weight);
        }
        public void PrimsMST(int sourceNode)
        {
            SortedSet<Node> set = new SortedSet<Node>();
            Nodelist.Find(e => e.Index == sourceNode).Weight = 0;
            for (int nodeIndex = 0; nodeIndex < NoOfNodes; nodeIndex++)
            {
                var node = Nodelist.Find(e => e.Index == nodeIndex);
                set.Add(node);
            }
            while (set.Count>0)
            {
                var currentNode = set.Min;
                foreach (var neighbourNode in currentNode.Neighbours)
                {
                    if(neighbourNode.Visited == false && neighbourNode.Weight > currentNode.NeighboursWeightedMap.GetValueOrDefault(neighbourNode))
                    {
                        neighbourNode.Weight = currentNode.NeighboursWeightedMap.GetValueOrDefault(neighbourNode);
                        neighbourNode.Parent = currentNode;
                    }
                }
                currentNode.Visited = true;
                set.Remove(currentNode);
            }

            int cost = 0;
            foreach (var node in Nodelist)
            {

                cost = cost + node.Weight;
            }
            Console.WriteLine("Minimum cost is "+ cost);
        }
    }
}
