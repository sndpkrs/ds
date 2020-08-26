using System;

namespace AdjMatrix
{
    public class GraphMatrix
    {
        public int NoOfNodes;
        public int[,] Matrix;
        public GraphMatrix(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            Matrix = new int[noOfNodes, noOfNodes];
            for (int i = 0; i < noOfNodes; i++)
            {
                for (int j = 0; j < noOfNodes; j++)
                {
                    Matrix[i, j] = 0;
                }
            }
        }
        public void AddEdge(int fromNode, int toNode)
        {
            if(fromNode >= NoOfNodes || toNode >= NoOfNodes)
            {
                Console.WriteLine("Invalid node specified");
                return;
            }
            Matrix[fromNode, toNode] = 1;
        }
        public void PrintGraph()
        {
            for (int i = 0; i < NoOfNodes; i++)
            {
                for (int j = 0; j < NoOfNodes; j++)
                {
                    Console.Write(Matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
