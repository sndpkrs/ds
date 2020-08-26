using System;

namespace AVL
{
    public class AVLTree
    {
        public AVLTreeNode RootNode;
        public int GetTreeHeight(AVLTreeNode rootNode)
        {
            if (rootNode is null) return -1;
            return rootNode.NodeHeight;
        }
        public AVLTree()
        {
        }
        public AVLTree(int data)
        {
            if (RootNode is null)
            {
                RootNode = new AVLTreeNode(data);
                RootNode.NodeHeight++;
            }
        }
        public void InsertInAVLTree(int data)
        {
            RootNode = InsertInAVLTreeAtGivenLevel(RootNode, data);
        }
        public AVLTreeNode InsertInAVLTreeAtGivenLevel(AVLTreeNode rootNode, int data)
        {
            //InsertInTree
            if (rootNode is null)
            {
                rootNode = new AVLTreeNode(data);
                return rootNode;
            }
            else if(rootNode.Data > data)
            {
                rootNode.LeftChild = InsertInAVLTreeAtGivenLevel(rootNode.LeftChild, data);
            }
            else if (rootNode.Data < data)
            {
                rootNode.RightChild = InsertInAVLTreeAtGivenLevel(rootNode.RightChild, data);
            }
            rootNode.NodeHeight = 1 + Max(GetTreeHeight(rootNode.LeftChild), GetTreeHeight(rootNode.RightChild));
            //RotateIfRequired
            int balance = GetBalance(rootNode);
            if(balance < -1)
            {

            }
            else if(balance > 1)
            {

            }
            return rootNode;
        }

        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public int GetBalance(AVLTreeNode rootNode)
        {
            return GetTreeHeight(rootNode.LeftChild) - GetTreeHeight(rootNode.RightChild);
        }
        public void RotateLeft()
        {

        }
        public void RotateRight()
        {

        }
    }
}
