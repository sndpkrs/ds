 using System;
using System.Collections.Generic;

namespace DisjointSets
{
    class Program
    {
        static void Main(string[] args)
        {
            DSet set = new DSet(0);
            var nodelist = new List<Node>();
            for (int i = 0; i < 5; i++)
            {
                nodelist.Add(new Node(i));
            }
            set.MakeSet(nodelist);
            set.PrintAllNodes();
            var uset = set.Union(nodelist.Find(e => e.Index == 1), nodelist.Find(e => e.Index == 2));
            uset.PrintAllNodes();
            set.PrintAllNodes();
            Console.ReadKey();
        }
    }
}
