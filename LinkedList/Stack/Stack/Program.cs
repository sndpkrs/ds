using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray sa = new StackArray();

            sa.Push(10);
            sa.Push(20);
            sa.Push(30);
            sa.Push(40);
            sa.PrintStack();
            sa.Peek();
            Console.WriteLine("Item popped from Stack : {0}", sa.Pop());
            sa.PrintStack();
////////////////////////////////////////////////////////////

            StackLinkedList sll = new StackLinkedList();

            sll.Push(10);
            sll.Push(20);
            sll.Push(30);
            sll.Push(40);
            sll.PrintStack();
            sll.Peek();
            Console.WriteLine("Item popped from Stack : {0}", sll.Pop());
            sll.PrintStack();
            Console.ReadLine();
        }
    }
}
