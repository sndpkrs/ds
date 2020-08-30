using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisjointSets
{
    public class DSet
    {
        public List<Node> Nodelist;
        public int NoOfNodes;
        public DSet(int noOfNodes)
        {
            NoOfNodes = noOfNodes;
            Nodelist = new List<Node>();
            for (int i = 0; i < NoOfNodes; i++)
            {
                Nodelist.Add(new Node(i));
            }
        }
        public void MakeSet(List<Node> nodelist)
        {
            Nodelist = nodelist;
            foreach (var node in Nodelist)
            {
                var dset = new DSet(0);
                dset.Nodelist.Add(node);
                node.Set = dset;
            }
        }
        public DSet FindSet(Node node)
        {
            return node.Set;
        }
        public DSet Union(Node node1, Node node2)
        {
            if (node1.Set == node2.Set)
                return null;
            else if (node1.Set.Nodelist.Count > node2.Set.Nodelist.Count)
            {
                var set2nodes = node2.Set.Nodelist;
                for (int nodeIndex = 0; nodeIndex < set2nodes.Count; nodeIndex++)
                {
                    var node = set2nodes.Find(e => e.Index == nodeIndex);
                    node.Set = node1.Set;
                    node1.Set.Nodelist.Add(node);
                }
                return node1.Set;
            }
            else
            {
                var set1nodes = node1.Set.Nodelist;
                for (int nodeIndex = 0; nodeIndex < set1nodes.Count; nodeIndex++)
                {
                    var node = set1nodes.GetRange(nodeIndex,1).First();
                    node.Set = node2.Set;
                    node2.Set.Nodelist.Add(node);
                }
                return node2.Set;
            }
        }
        public void PrintAllNodes()
        {
            foreach (var node in Nodelist)
            {
                Console.Write(node.Name + "   ");
            }
            Console.WriteLine();
        }
    }
}
