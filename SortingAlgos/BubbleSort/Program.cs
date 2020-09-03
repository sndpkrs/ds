using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            BubbleSort(array);
            Console.ReadKey();
        }
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(array, j, j + 1);
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
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
