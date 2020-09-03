using System;
using System.Collections.Generic;
using System.Text;

namespace PrimsMST
{
    public class Node:IComparable<Node>
    {
        public int Index;
        public string Name;
        public int Weight;
        public Node Parent;
        public bool Visited;
        public LinkedList<Node> Neighbours;
        public Dictionary<Node, int> NeighboursWeightedMap;
        public Node(int index)
        {
            Index = index;
            Name = "Node " + index;
            Weight = Int32.MaxValue / 10;
            Neighbours = new LinkedList<Node>();
            NeighboursWeightedMap = new Dictionary<Node, int>();
        }

        public int CompareTo(Node other)
        {
            return this.Weight - other.Weight;
        }
    }
}
