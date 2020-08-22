// C# program of Next Greater Frequency Element 
using System;
using System.Collections;

class GFG
{

    /*NFG function to find the 
    next greater frequency 
    element for each element 
    in the array*/
    static void NFG(int[] a, int n, int[] freq)
    {

        // stack data structure to store 
        // the position of array element 
        Stack s = new Stack();
        s.Push(0);

        // res to store the value of next greater 
        // frequency element for each element 
        int[] res = new int[n];
        for (int i = 0; i < n; i++)
            res[i] = 0;

        for (int i = 1; i < n; i++)
        {
            /* If the frequency of the element which is 
                pointed by the top of stack is greater 
                than frequency of the current element 
                then Push the current position i in stack*/

            if (freq[a[(int)s.Peek()]] > freq[a[i]])
                s.Push(i);
            else
            {
                /*If the frequency of the element which 
                is pointed by the top of stack is less 
                than frequency of the current element, then 
                Pop the stack and continuing Popping until 
                the above condition is true while the stack 
                is not empty*/

                while (freq[a[(int)(int)s.Peek()]] < freq[a[i]] &&
                                                        s.Count > 0)
                {
                    res[(int)s.Peek()] = a[i];
                    s.Pop();
                }

                // now Push the current element 
                s.Push(i);
            }
        }

        while (s.Count > 0)
        {
            res[(int)s.Peek()] = -1;
            s.Pop();
        }

        for (int i = 0; i < n; i++)
        {

            // Print the res list containing next 
            // greater frequency element 
            Console.Write(res[i] + " ");
        }
    }

    // Driver code 
    public static void Main(String[] args)
    {

        int[] a = { 1, 1, 2, 3, 4, 2, 1 };
        int len = 7;
        int max = int.MinValue;
        for (int i = 0; i < len; i++)
        {
            // Getting the max element of the array 
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        int[] freq = new int[max + 1];

        for (int i = 0; i < max + 1; i++)
            freq[i] = 0;

        // Calculating frequency of each element 
        for (int i = 0; i < len; i++)
        {
            freq[a[i]]++;
        }
        NFG(a, len, freq);
        Console.ReadKey();
    }
}

// This code is contributed by Arnab Kundu 
