using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public static class BinarySearchPrograms
    {
        //Simple Binary Search 
        //It require Sorted array
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;

        }

        /// <summary>
        /// This method will return greatest number which is greater than or equal to target.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns>Integer</returns>
        public static int SealingOfTarget(int[] arr, int target)
        {
            if (target < arr[arr.Length - 1])
            {
                return -1;
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return right;
        }
        /// <summary>
        /// This method will return and integer value from given array which is smallest than or equal to target.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns>Integer</returns>
        public static int FlooreOfTarget(int[] arr, int target)
        {
            if (target > arr[arr.Length - 1])
            {
                return -1;
            }
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                    return mid;
                if (target < arr[mid])
                {
                    end = mid - 1;

                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                    return mid;
            }
            return end;
        }

        public static int[] SearchElementIn2Dmatrix(int[][] arr, int target)
        {
            int r = 0;
            int c = arr.Length - 1;
            while (r < arr.Length && c >= 0)
            {
                if (arr[r][c] == target)
                {
                    return new int[] { r, c };
                }
                if (arr[r][c] < target)
                {
                    r++;
                }
                else
                {
                    c--;
                }
            }
            return new int[] { -1, -1 };
        }


    }


    public sealed class SingletonDemo
    {
        private SingletonDemo() { }

        private static SingletonDemo instance = null;

        public static SingletonDemo MyProperty
        {
            get
            {
                if (instance is null)
                {
                    instance = new SingletonDemo();
                }
                return instance;
            }
        }
    }
    public static class Sorting
    {
        public static void ArrayQuickSort(int[] arr, int low, int hi)
        {
            if (low >= hi)
            {
                return;
            }
            int s = low;
            int e = hi;
            int m = low + (e - s) / 2;
            int pivot = arr[m];
            while (s <= e)
            {
                while (arr[s] < pivot)
                {
                    s++;
                }
                while (arr[e] > pivot)
                {
                    e--;
                }
                if (s <= e)
                {
                    int temp = arr[s];
                    arr[s] = arr[e];
                    arr[e] = temp;
                    s++;
                    e--;
                }
            }
            ArrayQuickSort(arr, low, e);
            ArrayQuickSort(arr, s, hi);

        }

    }


}
