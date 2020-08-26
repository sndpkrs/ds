using System;
using BST;

namespace BSTOrchestrator
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.InsertInBST(1);
            bst.InsertInBST(10);
            bst.InsertInBST(3);
            bst.InsertInBST(99);
            bst.InsertInBST(5);
            bst.InsertInBST(6);
            bst.InsertInBST(98);
            bst.InsertInBST(9);
            bst.PreorderTraversal(bst.RootNode);
            bst.DeleteFromBST(3);
            Console.WriteLine();
            bst.PreorderTraversal(bst.RootNode);
            Console.ReadKey();
        }
    }
}
