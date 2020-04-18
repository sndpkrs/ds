using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinearQueueArray
    {
        public int[] IntArray { get; set; }
        public int Top { get; set; }
        public int Begin { get; set; }
        public const int ARRAY_SIZE = 100;
        public LinearQueueArray()
        {
            IntArray = new int[ARRAY_SIZE];
            Top = Begin = -1;
        }
        public bool IsEmpty()
        {
            return Begin == -1;
        }
        public bool IsFull()
        {
            return Top >= ARRAY_SIZE - 1;
        }
        public void Enqueue(int data)
        {
            if (IsFull()) throw new Exception("Queue is full");
            if (IsEmpty()) Begin++ ;
            IntArray[++Top] = data;
        }
        public int Dequeue()
        {
            if (IsEmpty()) throw new Exception("Queue is empty");
            var value = IntArray[Begin++];
            if (Begin > Top) Begin = Top = -1;
            return value;
        }
        public int PeekQueue()
        {
            if (IsEmpty()) throw new Exception("queue is empty");
            return IntArray[Begin];
        }
        public void PrintQueue()
        {
            for (int i = Begin; i <= Top; i++)
            {
                Console.Write("--->" + IntArray[i]);
            }
            Console.WriteLine();
        }
    }
}
