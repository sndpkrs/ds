using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList(10);
            ll.PrintList();
            ll.AddNode(2);
            ll.AddNode(3);
            ll.AddNode(4);
            ll.AddNode(5);
            ll.PrintList();
            ll.AddNode(6, 2);
            ll.AddNode(7, 2);
            ll.PrintList();
            ll.AddNode(8, 101);
            ll.AddNode(9, 102);
            ll.PrintList();
            ll.DeleteNode(4);
            ll.PrintList();
            ll.DeleteNode(0);
            ll.PrintList();
            ll.DeleteNode(6);
            ll.PrintList();
            Console.WriteLine(ll.SearchNode(2));

            ///////////////////////////////////////////////////////////////

            CircularLinkedList cll = new CircularLinkedList(10);
            cll.PrintList();
            cll.AddNode(2);
            cll.AddNode(3);
            cll.AddNode(4);
            cll.AddNode(5);
            cll.PrintList();
            cll.AddNode(6, 2);
            cll.AddNode(7, 2);
            cll.PrintList();
            cll.AddNode(8, 101);
            cll.AddNode(9, 102);
            cll.PrintList();
            cll.DeleteNode(4);
            cll.PrintList();
            cll.DeleteNode(0);
            cll.PrintList();
            cll.DeleteNode(6);
            cll.PrintList();
            Console.WriteLine(cll.SearchNode(2));

            ///////////////////////////////////////////////////////////////

            DoublyLinkedList dll = new DoublyLinkedList(10);
            dll.PrintList();
            dll.AddNode(2);
            dll.AddNode(3);
            dll.AddNode(4);
            dll.AddNode(5);
            dll.PrintList();
            dll.AddNode(6, 2);
            dll.AddNode(7, 2);
            dll.PrintList();
            dll.AddNode(8, 101);
            dll.AddNode(9, 102);
            dll.PrintList();
            dll.DeleteNode(4);
            dll.PrintList();
            dll.DeleteNode(0);
            dll.PrintList();
            dll.DeleteNode(6);
            dll.PrintList();
            Console.WriteLine(dll.SearchNode(2));
            dll.ReversePrint();

            ///////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine();
            DoublyCircularLinkedList dcll = new DoublyCircularLinkedList(10);
            dcll.PrintList();
            dcll.AddNode(2);
            dcll.AddNode(3);
            dcll.AddNode(4);
            dcll.AddNode(5);
            dcll.PrintList();
            dcll.AddNode(6, 2);
            dcll.AddNode(7, 2);
            dcll.PrintList();
            dcll.AddNode(8, 101);
            dcll.ReversePrint();
            dcll.AddNode(9, 102);
            dcll.PrintList();
            dcll.DeleteNode(4);
            dcll.PrintList();
            dcll.DeleteNode(0);
            dcll.PrintList();
            dcll.ReversePrint();
            dcll.DeleteNode(6);
            dcll.PrintList();
            Console.WriteLine(dcll.SearchNode(2));
            
            Console.ReadKey();
        }
    }
}
