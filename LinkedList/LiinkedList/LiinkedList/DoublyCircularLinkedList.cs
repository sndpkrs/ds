using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class DoublyCircularLinkedList
    {
        public DNode Head { get; set; }
        public DNode Tail { get; set; }
        public DoublyCircularLinkedList(int data)
        {
            DNode newNode = new DNode(data);
            newNode.Prev = newNode.Next = newNode;
            Head = Tail = newNode;
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
                newNode.Prev = newNode.Next = newNode;
                Head = Tail = newNode;
                return;
            }
            if(location == 0)
            {
                newNode.Next = Head;
                newNode.Prev = Head.Prev;
                Head.Prev = newNode;
                Head = newNode;
                Tail.Next = Head;
            }
            else if(location > 100)
            {
                newNode.Prev = Tail;
                newNode.Next = Tail.Next;
                Tail.Next = newNode;
                Tail = newNode;
                Head.Prev = newNode;
            }
            else
            {
                DNode tempNode = GetNodeAtLocation(location);
                newNode.Next = tempNode.Next;
                newNode.Prev = tempNode;
                tempNode.Next.Prev = newNode;
                tempNode.Next = newNode;
            }
        }
        public void DeleteNode(int location)
        {
            if (location < 0) throw new Exception("incorrect location mentioned");
            if(location == 0)
            {
                if(Head == Tail)
                {
                    Head = Tail = null;
                }
                else
                {
                    Head.Next.Prev = Head.Prev;
                    Tail.Next = Head.Next;
                    Head = Head.Next;
                }
            }
            else
            {
                DNode tempNode = GetNodeAtLocation(location - 1);
                if(tempNode == null || tempNode == Tail)
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
            } while (tempNode != Head);
            Console.WriteLine();
        }
        public void ReversePrint()
        {
            if (Tail is null) return;
            DNode tempNode = Tail;
            do
            {
                Console.Write("---->" + tempNode.Data);
                tempNode = tempNode.Prev;
            } while (tempNode != Tail);
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
            while (tempNode.Next != Head);
            return location;
        }
        public DNode GetNodeAtLocation(int location)
        {
            if (Head is null) return null;
            DNode tempNode = Head;
            int counter = 0;
            do
            {
                if (counter == location)
                    break;
                tempNode = tempNode.Next;
                counter++;
            }
            while (tempNode.Next != Head);
            return tempNode;
        }
    }
}
