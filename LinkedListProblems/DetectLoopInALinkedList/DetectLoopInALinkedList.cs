using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectLoopInALinkedList
{
    public class DetectLoopInALinkedList
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(20);
            list.AddNode(4);
            list.AddNode(15);
            list.AddNode(10);
            list.Head.Next.Next.Next.Next = list.Head;
            if(IsThereALoop(list))
                Console.WriteLine("yes, loop found");
            else
                Console.WriteLine("No loop found");

            if(MarkVisitedNodeWithTempNode(list))
                Console.WriteLine("yes, loop found");
            else
                Console.WriteLine("No loop found");

            if (FloydsCycleFinding(list))
                Console.WriteLine("yes, loop found");
            else
                Console.WriteLine("No loop found");
            Console.ReadKey();
        }
        static bool IsThereALoop(LinkedList list)
        {
            var set = new HashSet<Node>();
            var tempNode = list.Head;
            while (tempNode != null)
            {
                if (set.Contains(tempNode)) return true;
                set.Add(tempNode);
                tempNode = tempNode.Next;
            }
            return false;
        }

        static bool MarkVisitedNodeWithTempNode(LinkedList list)
        {
            Node tempNode = new Node();
            Node traverseNode = list.Head;
            while (traverseNode != null)
            {
                if (traverseNode.Next == tempNode)
                    return true;
                var traverseNodeCopy = traverseNode;
                traverseNode.Next = tempNode;
                traverseNode = traverseNodeCopy.Next;
            }
            return false;
        }
        static bool FloydsCycleFinding(LinkedList list)
        {
            Node slowPointer, fastPointer;
            slowPointer = fastPointer = list.Head;
            while (fastPointer != null && fastPointer.Next != null)
            {
                if (slowPointer == fastPointer)
                {
                    slowPointer = list.Head;
                    while(slowPointer != null)
                    {
                        if(slowPointer == fastPointer)
                        {
                            Console.WriteLine("the value of first node is "+ slowPointer.Data);
                            break;
                        }
                        slowPointer = slowPointer.Next;
                        fastPointer = fastPointer.Next;
                    }
                    return true;
                }
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
            }
            return false;
        }
    }
}
