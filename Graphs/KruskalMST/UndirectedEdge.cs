using DisjointSetLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace KruskalMST
{
    public class UndirectedEdge:IComparable<UndirectedEdge>
    {
        public Node First;
        public Node Second;
        public int Weight;
        public UndirectedEdge(Node firstNode, Node secondNode, int weight)
        {
            First = firstNode;
            Second = secondNode;
            Weight = weight;
        }

        public int CompareTo(UndirectedEdge other)
        {
            return this.Weight - other.Weight;
        }
    }
}
