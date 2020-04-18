using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class DoublyLinkedList
    {
        public DNode Head { get; set; }
        public DNode Tail { get; set; }
        public DoublyLinkedList()
        {
            this.Head = this.Tail = null;
        }
        public DoublyLinkedList(int data)
        {
            DNode tempNode = new DNode(data);
            tempNode.Prev = null;
            this.Head = this.Tail = tempNode;
        }
        public void AddNode(int data, int location = 0)
        {
            if (location < 0)
            {
                throw new Exception("invalid locaion mentioned");
            }
            DNode newNode = new DNode(data);
            if (Head is null)
            {
                Head = newNode;
                Tail = newNode;
                newNode.Prev = null;
                newNode.Next = null;
            }
            else if(location == 0)
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                this.Head = newNode;
            }
            else if(location > 100)
            {
                newNode.Prev = this.Tail;
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            else
            {
                DNode tempNode = GetDNodeAtLocation(location);
                newNode.Prev = tempNode;
                newNode.Next = tempNode.Next;
                tempNode.Next.Prev = newNode;
                tempNode.Next = newNode;
            }
        }
        public void DeleteNode(int location)
        {
            if (location < 0)
            {
                throw new Exception("invalid locaion mentioned");
            }
            if (Head is null) return;
            if(location == 0)
            {
                if(Head == Tail)
                {
                    Head = Tail = null;
                    return;
                }
                else
                {
                    Head = Head.Next;
                    Head.Prev = null;
                }
            }
            else
            {
                DNode tempNode = GetDNodeAtLocation(location - 1);
                if (tempNode == null || tempNode == Tail)
                {
                    return;
                }
                else
                {
                    if(tempNode.Next == Tail)
                    {
                        Tail = tempNode;
                    }
                    else
                    {
                        tempNode.Next.Next.Prev = tempNode;
                    }
                    tempNode.Next = tempNode.Next.Next;
                }
            }
        }
        public void PrintList()
        {
            if (Head is null) return;
            DNode tempNode = Head;
            do
            {
                Console.Write("---->" + tempNode.Data);
                tempNode = tempNode.Next;
            }
            while (tempNode != null);
            Console.WriteLine();
        }
        public int SearchNode(int data)
        {
            int location = -1;
            int counter = 0;
            if (Head is null) return location;
            DNode tempNode = Head;
            do
            {
                if (tempNode.Data == data)
                    return counter;
                tempNode = tempNode.Next;
                counter++;
            }
            while (tempNode.Next != null);
            return location;
        }
        public void ReversePrint()
        {
            if (Tail is null) return;
            DNode tempNode = Tail;
            while(tempNode != null)
            {
                Console.Write("--->" + tempNode.Data);
                tempNode = tempNode.Prev;
            }
            Console.WriteLine();
        }
        public DNode GetDNodeAtLocation(int location)
        {
            DNode tempNode = Head;
            int counter = 0;
            while (tempNode != null)
            {
                if (counter == location)
                    break;
                tempNode = tempNode.Next;
                counter++;
            }
            return tempNode;
        }
    }
}
