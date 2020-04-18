using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class CircularLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public CircularLinkedList()
        {
            this.Head = this.Tail = null;
        }
        public CircularLinkedList(int data)
        {
            Node node = new Node(data);
            node.Next = node;
            this.Head = this.Tail = node;
        }
        public void AddNode(int data, int location = 0)
        {
            if (location < 0)
            {
                throw new Exception("invalid locaion mentioned");
            }
            Node newNode = new Node(data);
            if (Head is null)
            {
                this.Head = this.Tail = newNode;
                newNode.Next = newNode;
                return;
            }
            else if (location == 0)
            {
                newNode.Next = this.Head;
                this.Head = newNode;
                this.Tail.Next = this.Head;
            }
            else if (location > 100)
            {
                newNode.Next = Head;
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            else
            {
                Node tempNode = GetNodeAtLocation(location);
                newNode.Next = tempNode.Next;
                tempNode.Next = newNode;
            }
        }
        public void PrintList()
        {
            if (Head is null) return;
            Node tempNode = Head;
            do
            {
                Console.Write("---->" + tempNode.Data);
                tempNode = tempNode.Next;
            }
            while (tempNode != this.Head);
            Console.WriteLine();
        }
        public void DeleteNode(int location)
        {
            if (location < 0) throw new Exception("invalid locaion mentioned");
            if (this.Head is null) return;
            if (location == 0)
            {
                if (this.Head == this.Tail)
                {
                    this.Head = this.Tail = null;
                    return;
                }
                this.Head = this.Head.Next;
                this.Tail.Next = this.Head;
            }
            else
            {
                Node tempNode = GetNodeAtLocation(location - 1);
                if(tempNode == null || tempNode == Tail)
                {
                    return;
                }
                else
                {
                    if (tempNode.Next == Tail)
                    {
                        Tail = tempNode;
                    }
                    tempNode.Next = tempNode.Next.Next;
                    return;
                }
            }
        }
        public int SearchNode(int data)
        {
            int location = -1;
            int counter = 0;
            if (Head is null) return location;
            Node tempNode = Head;
            do
            {
                if (tempNode.Data == data)
                    return counter;
                tempNode = tempNode.Next;
                counter++;
            }
            while (tempNode.Next != Head);
            return location;
        }
        public Node GetNodeAtLocation(int location)
        {
            Node tempNode = Head;
            int counter = 0;
            do
            {
                if (counter == location)
                    break;
                counter++;
                tempNode = tempNode.Next;
            }
            while (tempNode.Next != Head);
            return tempNode;
        }
    }

}
