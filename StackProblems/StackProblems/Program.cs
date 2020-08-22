// C# linear time solution for 
// stock span problem 
using System;
using System.Collections;

class GFG
{
    static void calculateSpan(int[] price, int n, int[] S)
    {
        Stack st = new Stack();
        st.Push(0);
        S[0] = 1;

        for (int i = 1; i < n; i++)
        { 
            while (st.Count > 0 && price[(int)st.Peek()] <= price[i])
                st.Pop();
            S[i] = (st.Count == 0) ? (i + 1) : (i - (int)st.Peek());
            st.Push(i);
        }
    }

    // A utility function to print elements of array 
    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

    // Driver method 
    public static void Main(String[] args)
    {
        int[] price = { 100,80,60,70,60,75,85};
        int n = price.Length;
        int[] S = new int[n];

        // Fill the span values in array S[] 
        calculateSpan(price, n, S);

        // print the calculated span values 
        printArray(S);
        Console.ReadKey();
    }
}

// This code is contributed by Arnab Kundu 
