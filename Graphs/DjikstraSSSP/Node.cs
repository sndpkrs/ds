using System;
using System.Collections.Generic;
using System.Text;

namespace DjikstraSSSP
{
    public class Node:IComparable<Node>
    {
        public string Name;
        public int Index;
        public int Weight;
        public LinkedList<Node> Neighbours;
        public bool Visited;
        public Node Parent;
        public Dictionary<Node, int> neighbourWeightMap;
        public Node(int index)
        {
            Index = index;
            Name = "Node " + index;
            Neighbours = new LinkedList<Node>();
            neighbourWeightMap = new Dictionary<Node, int>();
            Weight = Int32.MaxValue;
        }
        public int CompareTo(Node other)
        {
            return this.Weight - other.Weight;
        }
    }
}
