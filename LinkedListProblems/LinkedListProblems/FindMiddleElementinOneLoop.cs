using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiinkedList;
namespace LinkedListProblems
{
    /// <summary>
    /// Find middle index of a linked list in sinf=gle loop
    /// </summary>
    public class FindMiddleElementinOneLoop
    {
        static void Main(string[] args)
        {
            LinkedList LinkedList = new LinkedList();
            LinkedList.AddNode(1);
            LinkedList.AddNode(2);
            LinkedList.AddNode(3);
            LinkedList.AddNode(4);
            LinkedList.AddNode(5);
            Console.WriteLine(FindMiddleIndexWithNoTail(LinkedList));
            Console.ReadKey();
        }
        public static int FindMiddleIndexWithNoTail(LinkedList LinkedList)
        {
            if (LinkedList.Head is null) return 0;
            else
            {
                Node fastPointer, slowPointer;
                fastPointer = slowPointer = LinkedList.Head;
                int middleIndex = 0;
                while (fastPointer != null)
                {
                    if (fastPointer.Next == null) break;
                    fastPointer = fastPointer.Next.Next;
                    slowPointer = slowPointer.Next;
                    middleIndex++;
                }
                return slowPointer.Data;
            }
        }
    }
}
