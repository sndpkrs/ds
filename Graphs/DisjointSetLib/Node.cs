using System;
using System.Collections.Generic;
using System.Text;

namespace DisjointSetLib
{
    public class Node
    {
        public int Index;
        public string Name;
        public int Weight;
        public Node Parent;
        public DSet Set;
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
    }
}
