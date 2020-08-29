using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DjikstraSSSP
{
    public class DjikstraGraph
    {
        public int NoOfNodes;
        public List<Node> nodelist;
        public DjikstraGraph(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            nodelist = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                nodelist.Insert(i, new Node(i));
            }
        }
        public void AddWeightedEdge(int fromIndex, int toIndex, int weight)
        {
            var fromNode = nodelist.Find(e=>e.Index == fromIndex-1);
            var toNode = nodelist.Find(e => e.Index == toIndex-1);
            fromNode.Neighbours.AddLast(toNode);
            fromNode.neighbourWeightMap.Add(toNode, weight);
        }
        public void PrintPath(Node currentNode)
        {
            if(currentNode.Parent != null)
            {
                PrintPath(currentNode.Parent);
            }
            Console.Write(currentNode.Name + " --> ");
        }
        public void DjikstraSSSP(int sourceIndex)
        {
            var sourceNode = nodelist.Find(e => e.Index == sourceIndex-1);
            sourceNode.Weight = 0;
            MinHeap<Node> queue = new MinHeap<Node>();
            foreach (var node in nodelist)
            {
                queue.Add(node);
            }
            while (queue.Count>0)
            {
                var currentNode = queue.GetMin();
                PrintPath(currentNode);
                foreach (var neighbourNode in currentNode.Neighbours)
                {
                    if (queue.Contains(neighbourNode))
                    {
                        if(currentNode.Weight + currentNode.neighbourWeightMap.GetValueOrDefault(neighbourNode) < neighbourNode.Weight)
                        {
                            neighbourNode.Weight = currentNode.Weight + currentNode.neighbourWeightMap.GetValueOrDefault(neighbourNode);
                            neighbourNode.Parent = currentNode;
                        }
                    }
                }
                //RefreshQueue
                var newQueue = new MinHeap<Node>() { };
                foreach (var node in queue)
                {
                    if (node != currentNode)
                        newQueue.Add(node);
                }
                queue = newQueue;
                Console.WriteLine();
            }
        }
    }
}
