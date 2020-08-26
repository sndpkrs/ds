using BST;
using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BinarySearchTree
    {
        public TreeNode RootNode;
        public BinarySearchTree()
        {
            RootNode = null;
        }
        public BinarySearchTree(int data)
        {
            RootNode = new TreeNode(data);
        }
        public void SearchKeyInBST(TreeNode rootNode, int data)
        {
            if(rootNode == null)
            {
                return;
            }
            else
            {
                if(rootNode.Data == data)
                {
                    Console.WriteLine("Key Found");
                    return;
                }
                else if(rootNode.Data > data)
                {
                    SearchKeyInBST(rootNode.LeftChild, data);
                }
                else
                {
                    SearchKeyInBST(rootNode.RightChild, data);
                }
            }
        }
        public void InsertInBST(int data)
        {
            if(RootNode is null)
            {
                RootNode = new TreeNode(data);
                return;
            }
            else
            {
                SearchAndInsert(ref RootNode, data);
            }
        }
        public void SearchAndInsert(ref TreeNode rootNode, int data)
        {
            if(rootNode is null)
            {
                rootNode = new TreeNode(data);
            }
            else if(rootNode.Data > data)
            {
                SearchAndInsert(ref rootNode.LeftChild, data);
            }
            else
            {
                SearchAndInsert(ref rootNode.RightChild, data);
            }
        }
        public void PreorderTraversal(TreeNode rootNode)
        {
            if(rootNode is null)
            {
                return;
            }
            else
            {
                Console.Write("> "+ rootNode.Data);
                PreorderTraversal(rootNode.LeftChild);
                PreorderTraversal(rootNode.RightChild);
            }
        }
        public void DeleteFromBST(int data)
        {
            if(RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            else
            {
                RootNode = DeleteGivenNodeInBST(RootNode, data);
            }
        }
        public TreeNode DeleteGivenNodeInBST(TreeNode rootNode, int data)
        {
            if (rootNode is null) return rootNode;
            else if (rootNode.Data > data)
                rootNode.LeftChild = DeleteGivenNodeInBST(rootNode.LeftChild, data);
            else if (rootNode.Data < data)
                rootNode.RightChild = DeleteGivenNodeInBST(rootNode.RightChild, data);
            else
            {
                if (rootNode.LeftChild == null && rootNode.RightChild == null)
                {
                    rootNode = null;
                    return rootNode;
                }
                else if (rootNode.LeftChild == null && rootNode.RightChild != null)
                {
                    return rootNode.RightChild;
                }
                else if (rootNode.LeftChild != null && rootNode.RightChild == null)
                {
                    return rootNode.LeftChild;
                }
                else
                {
                    RootNode.Data = MinValue(rootNode);
                    RootNode.RightChild = DeleteGivenNodeInBST(rootNode.RightChild, data);
                }
            }
            return rootNode;
        }

        int MinValue(TreeNode rootNode)
        {
            int minv = rootNode.Data;
            while (rootNode.LeftChild != null)
            {
                minv = rootNode.LeftChild.Data;
                rootNode = rootNode.LeftChild;
            }
            return minv;
        }
        public TreeNode GetReferenceToThisNode(ref TreeNode rootNode, int data)
        {
            if(rootNode.Data == data)
            {
                return rootNode;
            }
            else if(rootNode.Data > data)
            {
                return GetReferenceToThisNode(ref rootNode.LeftChild, data);
            }
            else
            {
                return GetReferenceToThisNode(ref rootNode.RightChild, data);
            }
        }
        public int GetLeastValueOnRightSubtree(TreeNode rootNode)
        {
            return 0;
        }
    }
}
