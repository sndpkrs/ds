using System;
using System.Collections.Generic;
using System.Text;

namespace SSSPAlgo
{
    public class GraphSSSP
    {
        public int NoOfNodes;
        public Node[] NodeArray;
        public GraphSSSP(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            NodeArray = new Node[NoOfNodes];
            for (int i = 0; i < NoOfNodes; i++)
            {
                NodeArray[i] = new Node(i);
            }
        }
        public void AddEdgeDirected(int fromIndex, int toindex)
        {
            NodeArray[fromIndex].Neighbours.AddLast(NodeArray[toindex]);
        }
        public void AddEdgeUnDirected(int fromIndex, int toindex)
        {
            NodeArray[fromIndex].Neighbours.AddLast(NodeArray[toindex]);
            NodeArray[toindex].Neighbours.AddLast(NodeArray[fromIndex]);
        }
        public void SSSPWithBFS(int sourceNodeIndex)
        {
            Queue<Node> destinationNodeQueue = new Queue<Node>();
            destinationNodeQueue.Enqueue(NodeArray[sourceNodeIndex]);
            while(destinationNodeQueue.Count > 0)
            {
                var currentNode = destinationNodeQueue.Dequeue();
                currentNode.Visited = true;
                PrintPath(currentNode);
                foreach (var neighbourNode in currentNode.Neighbours)
                {
                    if (!NodeArray[neighbourNode.Index].Visited)
                    {
                        destinationNodeQueue.Enqueue(NodeArray[neighbourNode.Index]);
                        NodeArray[neighbourNode.Index].Visited = true;
                        NodeArray[neighbourNode.Index].Parent = currentNode;
                    }
                }
                Console.WriteLine();
            }
        }
        public void PrintPath(Node currentNode)
        {
            if (currentNode.Parent != null)
                PrintPath(currentNode.Parent);
            Console.Write(currentNode.Name + " --> ");
        }
    }
}
