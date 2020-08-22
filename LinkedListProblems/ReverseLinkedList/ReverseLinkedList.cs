using LiinkedList;
using Queue;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class ReverseLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(37);
            list.AddNode(98);
            list.AddNode(17);
            list.AddNode(49);
            list.AddNode(91);
            list.AddNode(7);
            list.PrintList();
            list = ReverseList(list);
            list.PrintList();
            ReverseListInPlace(list);
            list.PrintList();
            Console.ReadKey();
        }
        public static LinkedList ReverseList(LinkedList list)
        {
            LinearQueueLinkedList queue = new LinearQueueLinkedList();
            var tempNode = list.Head;
            while (tempNode != null)
            {
                queue.Enqueue(tempNode.Data);
                tempNode = tempNode.Next;
            }
            var newList = new LinkedList();
            while (!queue.IsEmpty())
            {
                newList.AddNode(queue.Dequeue());
            }
            list = newList;
            return list;
        }
        public static void ReverseListInPlace(LinkedList list)
        {
            if (list.Head is null || list.Head.Next is null)
                return;
            var traverseNode = list.Head;
            Node prevNode = null;
            while (traverseNode != null)
            {
                var traverseNext = traverseNode.Next;
                if (traverseNode == list.Head)
                    traverseNode.Next = null;
                else
                {
                    traverseNode.Next = list.Head;
                    list.Head = traverseNode;
                }
                traverseNode = traverseNext;
            }
        }
    }
}
