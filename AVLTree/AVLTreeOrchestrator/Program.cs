using System;
using AVL;

namespace AVLTreeOrchestrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new AVLTree();
            tree.InsertInAVLTree(10);
            tree.InsertInAVLTree(9);
            tree.InsertInAVLTree(8);
            tree.InsertInAVLTree(7);
            tree.InsertInAVLTree(6);
            tree.InsertInAVLTree(5);
            Console.ReadKey();
        }
    }
}
