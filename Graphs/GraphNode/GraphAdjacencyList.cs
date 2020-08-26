using System;
using System.Collections.Generic;
using System.Text;

namespace GraphNode
{
    public class GraphAdjacencyList
    {
        public int NoOfNodes;
        public LinkedList<int>[] adjList;
        public GraphAdjacencyList(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            adjList = new LinkedList<int>[NoOfNodes];
            for (int i = 0; i < NoOfNodes; i++)
            {
                adjList[i] = new LinkedList<int>();
            }
        }
        //undirected
        public void AddEdgeUndirected(int fromNode, int toNode)
        {
            adjList[fromNode].AddLast(toNode);
            adjList[toNode].AddLast(fromNode);
        }
        public void PrintGraph()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                if(adjList[i] != null)
                {
                    foreach (var item in adjList[i])
                    {
                        Console.Write(item + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void BFS(int sourceKey)
        {
            bool[] visited = new bool[NoOfNodes];
            for (int i = 0; i < NoOfNodes; i++)
            {
                visited[i] = false;
            }
            var toBeTraversedNodeQueue = new Queue<int>();
            toBeTraversedNodeQueue.Enqueue(sourceKey);
            visited[sourceKey] = true;
            while (toBeTraversedNodeQueue.Count > 0)
            {
                var currentNode = toBeTraversedNodeQueue.Dequeue();
                var adjListForCurrentNode = adjList[currentNode];
                foreach (var item in adjListForCurrentNode)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        toBeTraversedNodeQueue.Enqueue(item);
                    }
                }
                Console.Write(currentNode + "   ");
            }
        }
    }
}
