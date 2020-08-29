using System;
using System.Collections.Generic;
using System.Text;

namespace BellmanFordSSSP
{
    public class BellmanFordGraph
    {
        public int NoOfNodes;
        public List<Node> NodeList;
        public BellmanFordGraph(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            NodeList = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                NodeList.Insert(i, new Node(i));
            }
        }
        public void AddWeightedEdgeDirected(int fromNodeIndex, int toNodeIndex, int weight)
        {
            var fromNode = NodeList.Find(e=>e.Index == fromNodeIndex-1);
            var toNode = NodeList.Find(e => e.Index == toNodeIndex-1);
            fromNode.Neighbours.AddLast(toNode);
            fromNode.neighboursWeightMap.Add(toNode, weight);
        }
        public void PrintPath(Node currentNode)
        {
            if(currentNode.Parent != null)
            {
                PrintPath(currentNode.Parent);
            }
            Console.Write(currentNode.Name + " --> ");
        }
        public void BellmanFordSSSP(int sourceNodeIndex)
        {
            var sourceNode = NodeList.Find(e=>e.Index == sourceNodeIndex - 1);
            sourceNode.Weight = 0;
            // Noof Iteration V-1
            for (int i = 0; i < NoOfNodes -1; i++)
            {
                // foreach edge
                foreach (var currentNode in NodeList)
                {
                    foreach (var neighbourNode in currentNode.Neighbours)
                    {
                        if(currentNode.Weight + currentNode.neighboursWeightMap.GetValueOrDefault(neighbourNode) < neighbourNode.Weight)
                        {
                            neighbourNode.Weight = currentNode.Weight + currentNode.neighboursWeightMap.GetValueOrDefault(neighbourNode);
                            neighbourNode.Parent = currentNode;
                        }
                    }
                }
            }
            Console.WriteLine("Checking for negative cycle");
            foreach (var currentNode in NodeList)
            {
                foreach (var neighbourNode in currentNode.Neighbours)
                {
                    if(currentNode.Weight + currentNode.neighboursWeightMap.GetValueOrDefault(neighbourNode) < neighbourNode.Weight)
                    {
                        Console.WriteLine("Negative cycle found");
                        Console.WriteLine("Vertex is " + neighbourNode.Name);
                        return;
                    }
                }
            }
            Console.WriteLine("No cycle found");
            foreach (var currentNode in NodeList)
            {
                if(currentNode.Weight != Int32.MaxValue/10)
                {
                    Console.WriteLine(currentNode.Name + " minimum distance is " + currentNode.Weight);
                    PrintPath(currentNode);
                }
                else
                {
                    Console.WriteLine("No path found for "+ currentNode.Name);
                }
            }
        }
    }
}
