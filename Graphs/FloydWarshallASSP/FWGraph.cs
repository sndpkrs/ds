using System;
using System.Collections.Generic;
using System.Text;

namespace FloydWarshallASSP
{
    public class FWGraph
    {
        public int NoOfNodes;
        public List<Node> NodeList;
        public FWGraph(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            NodeList = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                NodeList.Add(new Node(i));
            }
        }
        public void AddWeightedEdge(int fromNodeIndex, int toNodeIndex, int weight)
        {
            var fromNode = NodeList.Find(e => e.Index == fromNodeIndex - 1);
            var toNode = NodeList.Find(e => e.Index == toNodeIndex - 1);
            fromNode.Neighbours.AddLast(toNode);
            fromNode.NeighboursWeightedMap.Add(toNode, weight);
        }

        public void FWAssp()
        {
            int[,] resultMatrix = new int[NoOfNodes, NoOfNodes];
            for (int i = 0; i < NoOfNodes; i++)
            {
                for (int j = 0; j < NoOfNodes; j++)
                {
                    if (i == j)
                    {
                        resultMatrix[i, j] = 0;
                    }
                    else if (NodeList.Find(e=>e.Index == i).Neighbours.Contains(NodeList.Find(f=>f.Index == j)))
                    {
                        resultMatrix[i, j] = NodeList.Find(e => e.Index == i).NeighboursWeightedMap.GetValueOrDefault(NodeList.Find(f => f.Index == j));
                    }
                    else
                    {
                        resultMatrix[i, j] = Int32.MaxValue / 10;
                    }
                }
            }

            // via nodes (warshall's algorithm)
            for (int viaNodeIndex = 0; viaNodeIndex < NoOfNodes; viaNodeIndex++)
            {
                // Improve result matrix
                for (int row = 0; row < NoOfNodes; row++)
                {
                    for (int column = 0; column < NoOfNodes; column++)
                    {
                        if(resultMatrix[row,column] > resultMatrix[row,viaNodeIndex] + resultMatrix[viaNodeIndex, column])
                        {
                            resultMatrix[row, column] = resultMatrix[row, viaNodeIndex] + resultMatrix[viaNodeIndex, column];
                        }
                    }
                }
            }

            for (int sourceNodeIndex = 0; sourceNodeIndex < NoOfNodes; sourceNodeIndex++)
            {
                Console.WriteLine("Printing distance list for node "+ NodeList.Find(e=>e.Index == sourceNodeIndex).Name);
                for (int destNodeIndex = 0; destNodeIndex < NoOfNodes; destNodeIndex++)
                {
                    Console.Write(resultMatrix[sourceNodeIndex, destNodeIndex] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
