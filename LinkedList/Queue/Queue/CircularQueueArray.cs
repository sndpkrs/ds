using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CircularQueueArray
    {
        public int[] IntArray { get; set; }
        public const int ARRAY_SIZE = 5;
        public int Top { get; set; }
        public int Begin { get; set; }
        public CircularQueueArray()
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
            return (Begin - Top == 1) || (Begin == 0 && Top == ARRAY_SIZE-1);
        }
        public void Enqueue(int data)
        {
            if (IsFull()) throw new Exception("queue is full");
            if (IsEmpty()) Begin++;
            if (Top == ARRAY_SIZE - 1) Top = -1;
            IntArray[++Top] = data;
        }
        public int Dequeue()
        {
            if (IsEmpty()) throw new Exception("queue is empty");
            var value = IntArray[Top];
            if (Top == Begin)
                Top = Begin = -1;
            else if (Begin == ARRAY_SIZE - 1)
                Begin = 0;
            else
                Begin++;
            return value;
        }
        public int PeekQueue()
        {
            if (IsEmpty()) throw new Exception("queue is empty");
            return IntArray[Begin];
        }
        public void PrintQueue()
        {
            if(Top == Begin) Console.Write("--->" + IntArray[Top]);
            else if (Top < Begin)
            {
                for (int i = Begin; i < ARRAY_SIZE; i++)
                {
                    Console.Write("--->" + IntArray[i]);
                }
                for (int i = 0; i <= Top && Top < Begin; i++)
                {
                    Console.Write("--->" + IntArray[i]);
                }
            }
            else
            {
                for (int i = Begin; i <= Top; i++)
                {
                    Console.Write("--->" + IntArray[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
