using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodes
{
    class SwapNodes
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
            SwappingNodes(list, 7, 49);
            list.PrintList();
            SwappingNodes(list, 98, 49);
            list.PrintList();
            SwappingNodes(list, 91, 17);
            list.PrintList();
            Console.ReadKey();
        }
        static void SwappingNodes(LinkedList list, int data1, int data2)
        {
            Node firstPtr = null, secondPtr = null, prevfirstPtr = null, prevSecondPtr = null;
            Node tempNode = list.Head;
            // Logic is to get the prevFirst, first, prevSecond and second pointer
            while (tempNode != null)
            {
                if(tempNode.Data == data1)
                {
                    firstPtr = tempNode;
                }
                if (tempNode.Data == data2)
                {
                    secondPtr = tempNode;
                }
                if (firstPtr == null) prevfirstPtr = tempNode; // until we havent got our firstpointer
                if (secondPtr == null) prevSecondPtr = tempNode;// until we havent got our secondpointer
                tempNode = tempNode.Next;
            }

            // Simple, exchange the next pointers of first & second pointer with a temp node
            Node temp = firstPtr.Next;
            firstPtr.Next = secondPtr.Next;
            secondPtr.Next = temp;
            // Then go over and change previous pointers Nexts' and based on condition, change head/tail
            if (firstPtr == list.Head)
            {
                prevSecondPtr.Next = firstPtr;
                list.Head = secondPtr;
                return;
            }
            if (secondPtr == list.Head)
            {
                prevfirstPtr.Next = secondPtr;
                list.Head = firstPtr;
                return;
            }
            prevfirstPtr.Next = secondPtr;
            prevSecondPtr.Next = firstPtr;
        }
    }
}
