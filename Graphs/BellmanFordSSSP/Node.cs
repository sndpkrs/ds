using System;
using System.Collections.Generic;
using System.Text;

namespace BellmanFordSSSP
{
    public class Node
    {
        public int Index;
        public string Name;
        public int Weight;
        public Node Parent;
        public LinkedList<Node> Neighbours;
        public Dictionary<Node, int> neighboursWeightMap;
        public Node(int index)
        {
            Index = index;
            Weight = Int32.MaxValue/10;
            Name = "Node " + index;
            Neighbours = new LinkedList<Node>();
            neighboursWeightMap = new Dictionary<Node, int>();
        }
    }
}
