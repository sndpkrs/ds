using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateOddEvenNode
{
    class AggregateOdEvenNodes
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(7);
            list.AddNode(8);
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.AddNode(6);
            list.PrintList();
            AggregateNodesByIndexPrcatice2(list);
            list.PrintList();
            AggregateNodesByValues(list);
            list.PrintList();
            Console.ReadKey();
        }

        public static void AggregateNodesByIndexPrcatice2(LinkedList list)
        {
            if (list.Head is null || list.Head.Next is null || list.Head.Next is null)
                return;
            Node oddpointer = null, oddPointerLast = null, evenPointer = null, evenpointerlast = null;
            oddpointer = oddPointerLast = list.Head;
            evenPointer = evenpointerlast = list.Head.Next;
            Node traverseNode = evenpointerlast.Next;
            int i = 1;
            while (traverseNode != null)
            {
                Node traverseNext = traverseNode.Next;
                if(i%2 != 0)
                {
                    oddPointerLast.Next = traverseNode;
                    traverseNode.Next = evenPointer;
                    evenpointerlast.Next = traverseNext;
                    oddPointerLast = oddPointerLast.Next;
                }
                else
                {
                    evenpointerlast = evenpointerlast.Next;
                }
                traverseNode = traverseNext;
                i++;
            }









            //int i = 1;
            //while (traverseNode != null)
            //{
            //    if(i%2 != 0)
            //    {
            //        Node temp = traverseNode.Next;
            //        oddPointerLast.Next = evenpointerlast.Next;
            //        evenpointerlast.Next = temp;
            //        traverseNode.Next = evenPointer;
            //        oddPointerLast = oddPointerLast.Next;
            //        evenpointerlast = evenpointerlast.Next;
            //        traverseNode = evenpointerlast;
            //    }
            //    else
            //    {
            //        traverseNode = evenpointerlast.Next;
            //    }
            //    i++;
            //}

        }

        public static void AggregateNodesByIndex(LinkedList list)
        {
            if (list.Head == null || list.Head.Next == null || list.Head.Next.Next == null) return;
            Node oddPointer, eventPointerLast, oddPointerLast;
            eventPointerLast = list.Head;
            oddPointerLast = oddPointer = list.Head.Next;
            var traverseNode = oddPointer.Next;
            int i = 0;
            while (traverseNode != null)
            {
                var traverseNodeNext = traverseNode.Next;
                if (i % 2 == 0)
                {
                    traverseNode.Next = oddPointer;
                    eventPointerLast.Next = traverseNode;
                    eventPointerLast = eventPointerLast.Next;
                    oddPointerLast.Next = traverseNodeNext;
                }
                else
                {
                    oddPointerLast = oddPointerLast.Next;
                }
                traverseNode = traverseNodeNext;
                i++;
            }
        }

        public static void AggregateNodesByValues(LinkedList list)
        {
            if (list.Head == null || list.Head.Next == null || list.Head.Next.Next == null) return;
            Node oddPointer, evenPointer, eventPointerLast, oddPointerLast;
            oddPointer = evenPointer = eventPointerLast = oddPointerLast = null;
            var traverseNode = list.Head;
            while (traverseNode != null)
            {
                var traverseNodeNext = traverseNode.Next;
                if (traverseNode.Data % 2 == 0)
                {
                    if(eventPointerLast == null)
                    {
                        evenPointer = eventPointerLast = traverseNode;
                    }
                    else
                    {
                        eventPointerLast = traverseNode;
                    }
                }
                else
                {
                    if (oddPointer == null)
                    {
                        oddPointer = oddPointerLast = traverseNode;
                        list.Head = traverseNode;
                        traverseNode.Next = eventPointerLast;
                    }
                    else
                    {
                        traverseNode.Next = eventPointerLast;
                        oddPointerLast.Next = traverseNode;
                        oddPointerLast = traverseNode;
                    }
                }
                //list.PrintList();
                traverseNode = traverseNodeNext;
            }
        }
    }
}
