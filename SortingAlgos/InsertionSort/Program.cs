using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            InsertionSort(array);
            Console.ReadKey();
        }
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                PlaceItem(array, i);
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
        }
        public static void PlaceItem(int[] array, int index)
        {
            for (int i = index; i <= 0; i--)
            {
                if (array[index] < array[i])
                    Swap(array, index, i);
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
