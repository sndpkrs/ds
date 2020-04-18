using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public LinkedList()
        {
            this.Head = this.Tail = null;  
        }
        public LinkedList(int data)
        {
            Node node = new Node(data);
            this.Head = this.Tail = node;
        }
        public void AddNode(int data,  int location = 0)
        {
            if (location < 0)
            {
                throw new Exception("invalid locaion mentioned");
            }
            if (Head is null )
            {
                Node node = new Node(data);
                this.Head = this.Tail = node;
                return;
            }
            else if(location == 0)
            {
                Node newNode = new Node(data);
                newNode.Next = this.Head;
                this.Head = newNode;
            }
            else if(location > 100)
            {
                Node newNode = new Node(data);
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            else
            {
                Node tempNode = GetNodeAtLocation(location);
                Node newNode = new Node(data);
                newNode.Next = tempNode.Next;
                tempNode.Next = newNode;
            }
        }
        public void PrintList()
        {
            if (Head is null) return;
            Node tempNode = Head;
            while(tempNode != null)
            {
                Console.Write("---->" + tempNode.Data );
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }
        public void DeleteNode(int location)
        {
            if(location < 0) throw new Exception("invalid locaion mentioned");
            if (this.Head is null) return;

            if(location == 0)
            {
                if (this.Head == this.Tail)
                {
                    this.Head = this.Tail = null;
                    return;
                }
                this.Head = this.Head.Next;
            }
            else
            {
                Node tempNode = GetNodeAtLocation(location - 1);
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
            while(tempNode != null)
            {
                if (tempNode.Data == data)
                    return counter;
                tempNode = tempNode.Next;
                counter++;
            }
            return location;
        }
        public Node GetNodeAtLocation(int location)
        {
            Node tempNode = Head;
            int counter = 0;
            while(tempNode != null)
            {
                if (counter == location)
                    break;
                counter++;
                tempNode = tempNode.Next;
            }
            return tempNode;
        }
    }
}
