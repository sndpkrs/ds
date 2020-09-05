using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            MergeSort(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        public static void MergeSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(array, start, middle);
                MergeSort(array, middle+1, end);
                Merge(array, start, middle, end);
            }
        }
        public static void Merge(int[] array, int start, int middle, int end)
        {
            int size1 = middle - start + 1;
            int size2 = end - middle;

            int[] tempArray1 = new int[size1];
            int[] tempArray2 = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                tempArray1[i] = array[start + i];
            }
            for (int j = 0; j < size2; j++)
            {
                tempArray2[j] = array[middle + 1 + j];
            }

            int firstArrayIndex = 0, secondArrayIndex = 0;
            while (firstArrayIndex < size1 && secondArrayIndex < size2)
            {
                if(tempArray1[firstArrayIndex] < tempArray2[secondArrayIndex])
                {
                    array[start + firstArrayIndex + secondArrayIndex] = tempArray1[firstArrayIndex];
                    firstArrayIndex++;
                }
                else
                {
                    array[start + firstArrayIndex + secondArrayIndex] = tempArray2[secondArrayIndex];
                    secondArrayIndex++;
                }
            }
            while (firstArrayIndex < size1)
            {
                array[start + firstArrayIndex + secondArrayIndex] = tempArray1[firstArrayIndex++];
            }
            while (secondArrayIndex < size2)
            {
                array[start + firstArrayIndex + secondArrayIndex] = tempArray2[secondArrayIndex++];
            }
        }
    }
}
