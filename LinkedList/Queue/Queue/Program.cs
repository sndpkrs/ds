using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearQueueArray lqa = new LinearQueueArray();
            lqa.Enqueue(1);
            lqa.Enqueue(2);
            lqa.Enqueue(3);
            lqa.Enqueue(4);
            lqa.Enqueue(5);
            lqa.PrintQueue();
            lqa.Dequeue();
            lqa.Dequeue();
            lqa.PrintQueue();
            lqa.Enqueue(6);
            lqa.Enqueue(7);
            lqa.PrintQueue();
            lqa.Dequeue();
            lqa.Dequeue();
            lqa.PrintQueue();
            Console.WriteLine();

            CircularQueueArray cqa = new CircularQueueArray();
            cqa.Enqueue(1);
            cqa.Enqueue(2);
            cqa.Enqueue(3);
            cqa.Enqueue(4);
            cqa.Enqueue(5);
            cqa.PrintQueue();
            cqa.Dequeue();
            cqa.Dequeue();
            cqa.PrintQueue();
            cqa.Enqueue(6);
            cqa.Enqueue(7);
            cqa.PrintQueue();
            cqa.Dequeue();
            cqa.Dequeue();
            cqa.PrintQueue();
            Console.WriteLine();

            LinearQueueLinkedList lqll = new LinearQueueLinkedList();
            lqll.Enqueue(1);
            lqll.Enqueue(2);
            lqll.Enqueue(3);
            lqll.Enqueue(4);
            lqll.Enqueue(5);
            lqll.PrintQueue();
            lqll.Dequeue();
            lqll.Dequeue();
            lqll.PrintQueue();
            lqll.Enqueue(6);
            lqll.Enqueue(7);
            lqll.PrintQueue();
            lqll.Dequeue();
            lqll.Dequeue();
            lqll.PrintQueue();
            Console.ReadKey();
        }
    }
}
