using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodesWithoutSwappingData
{
    class SwapNodes
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(10);
            list.AddNode(20);
            //list.AddNode(30);
            //list.AddNode(40);
            //list.AddNode(50);
            //list.AddNode(60);
            //list.AddNode(70);
            //list.AddNode(80);
            var n = SwapNodesOfList(list.Head, 10, 20);


            Console.ReadKey();
        }

        static Node SwapNodesOfList(Node head_ref, int x, int y)
        {
            //var traverseNode = list.Head;
            //Node firstPtr, secondPtr;
            //firstPtr = null;
            //secondPtr = null;
            //while (firstPtr == null && secondPtr == null )
            //{
            //    if(traverseNode.Data == first)
            //    {
            //        firstPtr = traverseNode;
            //    }
            //    if(traverseNode.Data == second)
            //    {
            //        secondPtr = traverseNode;
            //    }
            //    if(firstPtr != null && secondPtr != null)
            //    {

            //    }
            //    traverseNode = traverseNode.Next;
            //}
            Node head = head_ref;

            // Nothing to do if x and y are same  
            if (x == y)
                return null;

            Node a = null, b = null;

            // search for x and y in the linked list  
            // and store therir pointer in a and b  
            while (head_ref.Next != null)
            {

                if ((head_ref.Next).Data == x)
                {
                    a = head_ref;
                }

                else if ((head_ref.Next).Data == y)
                {
                    b = head_ref;
                }

                head_ref = ((head_ref).Next);
            }

            // if we have found both a and b  
            // in the linked list swap current  
            // pointer and Next pointer of these  
            if (a != null && b != null)
            {
                Node temp = a.Next;
                a.Next = b.Next;
                b.Next = temp;
                temp = a.Next.Next;
                a.Next.Next = b.Next.Next;
                b.Next.Next = temp;
            }
            return head;
        }
    }
}
