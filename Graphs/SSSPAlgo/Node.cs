using System;
using System.Collections.Generic;
using System.Text;

namespace SSSPAlgo
{
    public class Node
    {
        public int Index;
        public Node Parent;
        public LinkedList<Node> Neighbours;
        public string Name;
        public bool Visited;
        public Node(int index)
        {
            Index = index;
            Name = "Number " + index;
            Parent = null;
            Neighbours = new LinkedList<Node>();
        }
    }
}
