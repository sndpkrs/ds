using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackArray
    {
        public int[] IntArray { get; set; }
        private int top { get; set; }
        public const int ARRAY_SIZE = 100;
        public StackArray()
        {
            IntArray = new int[ARRAY_SIZE];
            top = -1;
        }
        public bool IsEmpty()
        {
            return top < 0;
        }
        public bool IsFull()
        {
            return top >= ARRAY_SIZE - 1;
        }
        public void Push(int data)
        {
            if (IsFull()) throw new Exception("Stack is full");
            IntArray[++top] = data;
        }
        public int Pop()
        {
            if(IsEmpty()) throw new Exception("Stack is empty");
            var value = IntArray[top];
            IntArray[top] = Int32.MinValue;
            top--;
            return value;
        }
        public int Peek()
        {
            if (IsEmpty()) throw new Exception("Stack is empty");
            return IntArray[top];
        }
        public void PrintStack()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(IntArray[i]);
            }
        }
    }
}
