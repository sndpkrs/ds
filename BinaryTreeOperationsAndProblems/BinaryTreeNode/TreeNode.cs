using System;

namespace BinaryTreeNode
{
    public class TreeNode
    {
        public int Data;
        public TreeNode LeftChild;
        public TreeNode RightChild;

        public TreeNode(int data)
        {
            Data = data;
            LeftChild = null;
            RightChild = null;
        }
        public TreeNode(int data, TreeNode leftChild, TreeNode rightNode)
        {
            Data = data;
            LeftChild = leftChild;
            RightChild = rightNode;
        }
    }
}
