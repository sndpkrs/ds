using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinearQueueLinkedList
    {
        public LinkedList LinkedList { get; set; }
        public LinearQueueLinkedList()
        {
            LinkedList = new LinkedList();
        }
        public bool IsEmpty()
        {
            return LinkedList.Head == null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            if(LinkedList.Head is null)
            {
                LinkedList.Head = LinkedList.Tail = newNode;
            }
            else
            {
                LinkedList.Tail.Next = newNode;
                LinkedList.Tail = newNode;
            }
        }
        public int Dequeue()
        {
            var tempNode = LinkedList.Head;
            if (LinkedList.Head is null) throw new Exception("queue is empty");
            else if(LinkedList.Head == LinkedList.Tail)
            {
                LinkedList.Head = LinkedList.Tail = null;
            }
            else
            {
                LinkedList.Head = LinkedList.Head.Next;
            }
            return tempNode.Data;
        }
        public int PeekQueue()
        {
            if (LinkedList.Head is null) throw new Exception("queue is empty");
            return LinkedList.Head.Data;
        }
        public void PrintQueue()
        {
            if (LinkedList.Head == null) return;
            var tempNode = LinkedList.Head;
            while(tempNode != null)
            {
                Console.Write("--->" + tempNode.Data);
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }
    }
}
