using BinaryTreeNode;
using System;

namespace BinaryTreeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.AddNode(1);
            tree.RootNode.LeftChild = new TreeNode(2);
            tree.RootNode.RightChild = new TreeNode(3);
            tree.RootNode.LeftChild.RightChild = new TreeNode(4);
            tree.RootNode.LeftChild.RightChild.LeftChild = new TreeNode(90);
            tree.RootNode.RightChild.LeftChild = new TreeNode(5);
            tree.RootNode.RightChild.LeftChild.LeftChild = new TreeNode(99);
            tree.TraverseBinaryTree(tree, TraversalOrder.Preorder);
            Console.WriteLine();
            tree.TraverseBinaryTree(tree, TraversalOrder.Inorder);
            Console.WriteLine();
            tree.TraverseBinaryTree(tree, TraversalOrder.Postorder);
            Console.WriteLine();
            tree.TraverseBinaryTree(tree, TraversalOrder.LevelOrder);
            Console.WriteLine();
            tree.SearchByLevelOrder(tree, 3);
            Console.WriteLine();
            tree.AddNode(6);
            tree.TraverseBinaryTree(tree, TraversalOrder.Preorder);
            Console.WriteLine();
            Console.WriteLine("Height of tree until now is " + tree.GetHieght(tree.RootNode));
            // print nodes at given level
            int level = 3;
            Console.WriteLine("Nodes at level " + level);
            tree.PrintAtGivenLevel(tree.RootNode, level);
            Console.WriteLine();
            Console.WriteLine("Deepest Node is : " + tree.FindDeepestNode());
            Console.WriteLine();
            Console.WriteLine("Last Deepest Node is : " + tree.FindLastDeepestNode());
            Console.WriteLine();
            tree.DeleteNode();
            Console.WriteLine("Last Deepest Node is : " + tree.FindLastDeepestNode());
            Console.ReadKey();
        }

        public static void TraverseBinaryTree(BinaryTree tree)
        {

        }
    }
}
