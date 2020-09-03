using System;
using System.Collections.Generic;
using System.Linq;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 100, 70, 30, 90, 40, 80, 50, 20, 60, 10 };
            BucketSort(array);
            Console.ReadKey();
        }
        public static void BucketSort(int[] array)
        {
            int noOfBuckets = (int)Math.Ceiling(Math.Sqrt(array.Length));
            int maxValue = array.Max();
            var list = new List<List<int>>(noOfBuckets);
            for (int l = 0; l < noOfBuckets; l++)
            {
                list.Add(new List<int>());
            }
            for (int i = 0; i < array.Length; i++)
            {
                int bucketNo = (int)Math.Floor((double)(array[i] * noOfBuckets)/maxValue);
                list[bucketNo].Add(array[i]);
            }
            int finalArrayIndex = 0;
            // sort each bucket
            for (int k = 0; k < list.Count(); k++)
            {
                list[k].Sort();
                for (int j = 0; j < list[k].Count; j++)
                {
                    array[finalArrayIndex++] = list[k][j];
                }
                //QuickSortBucket(list);
            }
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }
            // Concatenate buckets

        }
        public static void QuickSortBucket(List<int> list)
        {

        }
    }
}
