using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeNode
{
    public class BinaryTree
    {
        public TreeNode RootNode;
        public BinaryTree()
        {
            RootNode = null;
        }

        public BinaryTree(int data)
        {
            RootNode = new TreeNode(data);
        }
        public BinaryTree CreateBinaryTree()
        {
            return this;
        }
        public void TraverseBinaryTree(BinaryTree tree, TraversalOrder traversalOrder = TraversalOrder.Preorder)
        {
            if(tree.RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            var tempNode = tree.RootNode;
            switch (traversalOrder)
            {
                case TraversalOrder.Preorder:
                    DoPreorderTraversal(tempNode);
                    break;
                case TraversalOrder.Inorder:
                    DoInorderTraversal(tempNode);
                    break;
                case TraversalOrder.Postorder:
                    DoPostOrderTraversal(tempNode);
                    break;
                case TraversalOrder.LevelOrder:
                    DoLevelOrderTraversal(tempNode);
                    break;
            }
        }
        public void DoPreorderTraversal(TreeNode rootNode)
        {
            var tempNode = rootNode;
            if (tempNode is null)
                return;
            Console.Write(rootNode.Data + "> ");
            DoPreorderTraversal(tempNode.LeftChild);
            DoPreorderTraversal(tempNode.RightChild);
        }
        public void DoPostOrderTraversal(TreeNode rootNode)
        {
            var tempNode = rootNode;
            if (tempNode is null)
                return;
            DoPostOrderTraversal(tempNode.RightChild);
            DoPostOrderTraversal(tempNode.LeftChild);
            Console.Write(tempNode.Data + "> ");
        }
        public void DoInorderTraversal(TreeNode rootNode)
        {
            var tempNode = rootNode;
            if (tempNode is null)
                return;
            DoInorderTraversal(rootNode.LeftChild);
            Console.Write(rootNode.Data + "> ");
            DoInorderTraversal(tempNode.RightChild);
        }
        public void DoLevelOrderTraversal(TreeNode rootNode)
        {
            var tempNode = rootNode;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(rootNode);
            while(queue.Count > 0)
            {
                if (queue.Peek().LeftChild != null)
                    queue.Enqueue(queue.Peek().LeftChild);
                if (queue.Peek().RightChild != null)
                    queue.Enqueue(queue.Peek().RightChild);
                Console.Write(queue.Peek().Data + "> ");
                queue.Dequeue();
            }
        }
        public void SearchByLevelOrder(BinaryTree tree, int searchData)
        {
            if(tree is null || tree.RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            else
            {
                int order = 1;
                if(tree.RootNode.Data == searchData)
                {
                    Console.WriteLine("Data found at root. i.e. order " + order);
                    return;
                }
                var tempNode = tree.RootNode;
                var queue = new Queue<TreeNode>();
                queue.Enqueue(tree.RootNode);
                while (queue.Count > 0)
                {
                    if(queue.Peek().LeftChild != null)
                    {
                        queue.Enqueue(queue.Peek().LeftChild);
                    }
                    if (queue.Peek().RightChild != null)
                    {
                        queue.Enqueue(queue.Peek().RightChild);
                    }
                    if(queue.Peek().Data == searchData)
                    {
                        Console.WriteLine("Number found ");
                        return;
                    }
                    Console.Write(queue.Peek().Data + "> ");
                    queue.Dequeue();
                }
                Console.WriteLine("Number not found");
            }
        }
        public void AddNode(int data)
        {
            if(RootNode is null)
            {
                RootNode = new TreeNode(data);
            }
            else
            {
                var queue = new Queue<TreeNode>();
                var tempNode = RootNode;
                queue.Enqueue(RootNode);
                while (queue.Count > 0)
                {
                    tempNode = queue.Peek();
                    if(tempNode.LeftChild == null)
                    {
                        tempNode.LeftChild = new TreeNode(data);
                        return;
                    }
                    if(tempNode.RightChild == null)
                    {
                        tempNode.RightChild = new TreeNode(data);
                        return;
                    }
                    queue.Enqueue(tempNode.LeftChild);
                    queue.Enqueue(tempNode.RightChild);
                    queue.Dequeue();
                }
            }
        }
        public void DeleteNode()
        {
            if(RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            else
            {
                int deepestNodeValue = DeleteAndReturnTheLastDeepestNode(ref RootNode, GetHieght(RootNode) + 1);
                if (deepestNodeValue > 0)
                    RootNode.Data = deepestNodeValue;
            }
        }
        public int DeleteAndReturnTheLastDeepestNode(ref TreeNode rootNode, int level)
        {
            if (rootNode is null)
                return 0;
            if(level == 1)
            {
                int numberFound = rootNode.Data;
                rootNode = null;
                return numberFound;
            }
            else
            {
                int numberFound = DeleteAndReturnTheLastDeepestNode(ref rootNode.RightChild, level - 1);
                if (numberFound > 0) return numberFound;
                numberFound = DeleteAndReturnTheLastDeepestNode(ref rootNode.LeftChild, level - 1);
                if (numberFound > 0) return numberFound;
            }
            return 0;
        }
        public int GetHieght(TreeNode rootNode)
        {
            if(rootNode.LeftChild == null && rootNode.RightChild == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = 0, rightHeight = 0;
                if(rootNode.LeftChild != null)
                    leftHeight = GetHieght(rootNode.LeftChild) + 1;
                if(rootNode.RightChild != null)
                    rightHeight = GetHieght(rootNode.RightChild) + 1;

                if (leftHeight > rightHeight)
                {
                    return leftHeight;
                }
                else
                    return rightHeight;
            }
        }
        public void PrintAtGivenLevel(TreeNode rootNode, int level)
        {
            if(rootNode == null)
            {
                return;
            }
            if(level == 1)
            {
                Console.Write(rootNode.Data + " > ");
            }
            else
            {
                PrintAtGivenLevel(rootNode.LeftChild, level - 1);
                PrintAtGivenLevel(rootNode.RightChild, level - 1);
            }
        }
        public int FindDeepestNode()
        {
            if (RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return 0;
            }
            int heightOfTree = GetHieght(RootNode);
            return FindFirstNodeAtgivenLevel(RootNode, heightOfTree + 1);
        }
        public int FindLastDeepestNode()
        {
            if (RootNode is null)
            {
                Console.WriteLine("Tree is empty");
                return 0;
            }
            int heightOfTree = GetHieght(RootNode);
            return FindLastNodeAtgivenLevel(RootNode, heightOfTree + 1);
        }
        public int FindFirstNodeAtgivenLevel(TreeNode rootNode, int level)
        {
            if(rootNode is null)
            {
                return 0;
            }
            if(level == 1)
            {
                return rootNode.Data;
            }
            else
            {
                int numberFound = FindFirstNodeAtgivenLevel(rootNode.LeftChild, level - 1);
                if (numberFound > 0) return numberFound;
                numberFound = FindFirstNodeAtgivenLevel(rootNode.RightChild, level - 1);
                if (numberFound > 0) return numberFound;
            }
            return 0;
        }
        public int FindLastNodeAtgivenLevel(TreeNode rootNode, int level)
        {
            if (rootNode is null)
                return 0;
            if(level == 1)
            {
                return rootNode.Data;
            }
            else
            {
                int numberFound = FindLastNodeAtgivenLevel(rootNode.RightChild, level - 1);
                if (numberFound > 0) return numberFound;
                numberFound = FindLastNodeAtgivenLevel(rootNode.LeftChild, level - 1);
                if (numberFound > 0) return numberFound;
            }
            return 0;
        }
    }
    public enum TraversalOrder
    {
        Preorder = 1,
        Inorder,
        Postorder,
        LevelOrder
    }
}
