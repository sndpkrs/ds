using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            SelectionSort(array);
            Console.ReadKey();
        }
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int smallestIndex = i; 
                // find min among the remaining elements.
                for (int j = i; j < array.Length; j++)
                {
                    if(array[j] < min)
                    {
                        min = array[j];
                        smallestIndex = j;
                    }
                }
                if (smallestIndex != i)
                    Swap(array, i, smallestIndex);
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
        }
        public static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
