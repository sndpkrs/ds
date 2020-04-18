using LiinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackLinkedList
    {
        public LinkedList LinkedList { get; set; }
        public StackLinkedList()
        {
            LinkedList = new LinkedList();
        }
        public bool IsEmpty()
        {
            return LinkedList.Head == null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = LinkedList.Head;
            LinkedList.Head = newNode;
        }
        public int Pop()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            Node tempNode = LinkedList.Head;
            LinkedList.Head = LinkedList.Head.Next;
            return tempNode.Data;
        }
        public int Peek()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            return LinkedList.Head.Data;
        }
        public void PrintStack()
        {
            if (LinkedList.Head is null) return;
            Node tempNode = LinkedList.Head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }
    }
}
