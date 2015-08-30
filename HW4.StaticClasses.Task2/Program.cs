using System;

namespace HW4.StaticClasses.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 1, 2, 10, 9 };
            Console.WriteLine("Original array: ");
            foreach (var item in array)
                Console.Write(" {0}  ", item);

            array.SortInAscending();

            Console.WriteLine("\nSorted array: ");
            foreach (var item in array)
                Console.Write(" {0}  ", item);

            Console.ReadKey();
        }
    }

    static class IntArrExt
    {
        public static void SortInAscending(this int[] arr)
        {
            int tmp;
            int minIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;

                tmp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tmp;
            }
        }
    }
}
