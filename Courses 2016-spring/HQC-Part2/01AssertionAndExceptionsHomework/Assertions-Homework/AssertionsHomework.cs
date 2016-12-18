using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arrayToSort) where T : IComparable<T>
        {
            Debug.Assert(arrayToSort != null, "Array is null!");
            Debug.Assert(arrayToSort.Length > 0, "Array is empty!");

            for (int index = 0; index < arrayToSort.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arrayToSort, index, arrayToSort.Length - 1);
                Swap(ref arrayToSort[index], ref arrayToSort[minElementIndex]);
            }
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Arrary is null");

            Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "StartIndex is out of range!");
            Debug.Assert(0 < endIndex && endIndex <= arr.Length - 1, "EndIndex is out of range!");
            Debug.Assert(startIndex <= endIndex, "Start Index is bigger than End index");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(0 <= minElementIndex && minElementIndex <= arr.Length - 1, "MinElementIndex is out if range");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "First swap value is null");
            Debug.Assert(y != null, "Second swap value is null");

            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(value != null, "Searching value is null");

            Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "StartIndex is out of range!");
            Debug.Assert(0 < endIndex && endIndex <= arr.Length - 1, "EndIndex is out of range!");
            Debug.Assert(startIndex <= endIndex, "Start Index is bigger than End index");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else 
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arrayToSort = [{0}]", string.Join(", ", arr));

            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            ////SelectionSort(new int[0]);

            // Test sorting single element array
            SelectionSort(new int[1]); 

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}
