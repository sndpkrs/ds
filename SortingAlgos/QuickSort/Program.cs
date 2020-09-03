using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            QuickSort(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        public static void QuickSort(int[] array, int start, int end)
        {
            if (start > end)
                return;
            int magicNo = array[end];
            int indexOfMagicNo = end;
            int j = start - 1;
            for (int i = start; i < end + 1; i++)
            {
                if(array[i] <= magicNo)
                {
                    j++;
                    Swap(array, i, j);
                }
            }
            QuickSort(array, start, j - 1);
            QuickSort(array, j + 1, end);
        }
        public static int[] Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            return array;
        }
    }
}
