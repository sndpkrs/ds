using System;
using System.Collections;
namespace MinimumNoFromSequence
{
    class Program
    {
        // Function to decode the given sequence to construct 
        // minimum number without repeated digits 
        static void PrintMinNumberForPattern(String seq)
        {
            // result store output string 
            String result = "";

            // create an empty stack of integers 
            Stack stk = new Stack();

            // run n+1 times where n is length of input sequence 
            for (int i = 0; i <= seq.Length; i++)
            {
                // push number i+1 into the stack 
                stk.Push(i + 1);

                // if all characters of the input sequence are 
                // processed or current character is 'I' 
                // (increasing) 
                if (i == seq.Length || seq[i] == 'I')
                {
                    // run till stack is empty 
                    while (stk.Count != 0)
                    {
                        // remove top element from the stack and 
                        // add it to solution 
                        result += String.Join("", stk.Peek());
                        result += " ";
                        stk.Pop();
                    }
                }
            }

            Console.WriteLine(result);
        }

        static String getMinNumberForPattern(String seq)
        {
            int n = seq.Length;

            if (n >= 9)
                return "-1";

            char[] result = new char[n + 1];

            int count = 1;

            // The loop runs for each input character 
            // as well as one additional time for 
            // assigning rank to each remaining characters  
            for (int i = 0; i <= n; i++)
            {
                if (i == n || seq[i] == 'I')
                {
                    for (int j = i - 1; j >= -1; j--)
                    {
                        result[j + 1] = (char)((int)'0' + count++);
                        if (j >= 0 && seq[j] == 'I')
                            break;
                    }
                }
            }
            return new String(result);
        }
        // main function 
        public static void Main()
        {
            PrintMinNumberForPattern("IDID");
            PrintMinNumberForPattern("I");
            PrintMinNumberForPattern("DD");
            PrintMinNumberForPattern("II");
            PrintMinNumberForPattern("DIDI");
            PrintMinNumberForPattern("IIDDD");
            PrintMinNumberForPattern("DDIDDIID");
            Console.WriteLine(getMinNumberForPattern("DDIDDIID"));
            Console.ReadKey();
        }
    }
}
