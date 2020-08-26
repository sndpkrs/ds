using System;
using System.Collections.Generic;
using System.Text;

namespace AVL
{
    public class AVLTreeNode
    {
        public int Data;
        public AVLTreeNode LeftChild;
        public AVLTreeNode RightChild;
        public int NodeHeight;

        public AVLTreeNode(int data)
        {
            Data = data;
            LeftChild = RightChild = null;
            NodeHeight = 0;
        }
        public int GetHeight(AVLTreeNode rootNode)
        {
            if (rootNode is null)
                return -1;
            return rootNode.NodeHeight;
        }
    }
}
