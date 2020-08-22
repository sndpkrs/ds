using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairWiseSwap
{
    class PairWiseSwapList
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
            PairWiseSwap(list);
            list.PrintList();
            Console.ReadKey();
        }
        static void PairWiseSwap(LinkedList list)
        {
            if (list.Head is null || list.Head.Next is null) return;
            Node oddpointer = list.Head, evenPointer = list.Head.Next;
            Node prevPointer = null;
            while (oddpointer != null && evenPointer != null)
            {
                Node temp = evenPointer.Next;
                evenPointer.Next = oddpointer;
                oddpointer.Next = temp;
                if (oddpointer == list.Head)
                {
                    list.Head = evenPointer;
                }
                else
                {
                    prevPointer.Next = evenPointer;
                }
                prevPointer = oddpointer;
                oddpointer = temp;
                if (oddpointer != null)
                    evenPointer = oddpointer.Next;
            }

        }
    }
}
