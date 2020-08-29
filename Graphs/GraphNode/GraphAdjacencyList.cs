using System;
using System.Collections.Generic;
using System.Text;

namespace GraphNode
{
    public class GraphAdjacencyList
    {
        public int NoOfNodes;
        public LinkedList<int>[] AdjList;
        public GraphAdjacencyList(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            AdjList = new LinkedList<int>[NoOfNodes];
            for (int i = 0; i < NoOfNodes; i++)
            {
                AdjList[i] = new LinkedList<int>();
            }
        }
        //undirected
        public void AddEdgeUndirected(int fromNode, int toNode)
        {
            AdjList[fromNode].AddLast(toNode);
            AdjList[toNode].AddLast(fromNode);
        }
        //undirected
        public void AddEdgeDirected(int fromNode, int toNode)
        {
            AdjList[fromNode].AddLast(toNode);
        }
        public void PrintGraph()
        {
            for (int i = 0; i < AdjList.Length; i++)
            {
                if(AdjList[i] != null)
                {
                    foreach (var item in AdjList[i])
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
                var adjListForCurrentNode = AdjList[currentNode];
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
        public void DFS(int sourceKey)
        {
            bool[] visited = new bool[NoOfNodes];
            Console.WriteLine();
            DFSRec(sourceKey, visited);
        }
        public void DFSRec(int node, bool[] visited)
        {
            visited[node] = true;
            Console.Write(node + "  ");
            foreach (var item in AdjList[node])
            {
                if(!visited[item])
                DFSRec(item, visited);
            }
        }
        public void TopologicalSort()
        {
            bool[] visited = new bool[NoOfNodes];
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                if(visited[i] != true)
                {
                    TSRec(i, visited, s);
                }
            }
            // Pop stack
            while(s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }
        }
        public void TSRec(int node, bool[] visited, Stack<int> s)
        {
            foreach (var item in AdjList[node])
            {
                if (!visited[item])
                {
                    TSRec(item, visited, s);
                }
            }
            visited[node] = true;
            s.Push(node);
        }
    }
}
