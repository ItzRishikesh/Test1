using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BinarySearch
{
    //Binary Search Algorithms.
    public static class BinarySearch
    {
        //Simple order agnostic Binary search alorithm which returns index of target.
        public static int SimpleBinarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];//Check array is ascending or descending
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    //Best case
                    return mid;
                }
                if (isAsc)
                {
                    //Runs if array is Ascending
                    if (target < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    //Runs if array is Descending
                    if (target > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return -1;
        }

        //Returns number if presnet in array Else smallest number greater than target.
        public static int CeilingOfNumberPresentInGivenArray(int[] arr, int target)
        {
            if (target > arr[arr.Length - 1])
            {
                return -1;
            }
            int start = 0, end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];//Check array is ascending or descending
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    //Best case
                    return mid;
                }
                if (isAsc)
                {
                    //Runs if array is Ascending
                    if (target < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    //Runs if array is Descending
                    if (target > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return start;
        }

        //Returns number if presnet in array Else Greatest number smaller than target.
        public static int FlooreOfNumberPresentInGivenArray(int[] arr, int target)
        {
            if (target < arr[0])
            {
                return -1;
            }
            int start = 0, end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];//Check array is ascending or descending
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    //Best case
                    return mid;
                }
                if (isAsc)
                {
                    //Runs if array is Ascending
                    if (target < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    //Runs if array is Descending
                    if (target > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return end;
        }
        public static int SmallestLetterGreaterThanTarget(char[] arr, char target)
        {

            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (target < arr[mid])
                {
                    end = end - 1;
                }
                else
                {
                    end = mid + 1;
                }
            }
            return arr[start % arr.Length];
        }
        public static int[] FindTheFirstAndLastPositionOfTarget(int[] arr, int target)
        {
            int[]ans= { -1, -1 };
            int start = Search(arr, target, true);
            int end= Search(arr, target, false);
            ans[0] = start;
            ans[1] = end;
            return ans;
        }
        private static int Search(int[] arr,int target,bool findStartIndex)
        {
            int ans = -1;
            int start = 0, end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];//Check array is ascending or descending
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    //Best case
                    return mid;
                }

                //Runs if array is Ascending
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else if(target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    ans = mid;
                    if (findStartIndex)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start= mid+1;
                    }
                }
            }
            return -1;
        }

        //Find postion of an element in a sorted array of infinite numbers
        public static int FindElementFromInfiniteArray(int[] arr, int target, int start, int end)
        {
            
            bool isAsc = arr[start] < arr[end];//Check array is ascending or descending
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    //Best case
                    return mid;
                }
                if (isAsc)
                {
                    //Runs if array is Ascending
                    if (target < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    //Runs if array is Descending
                    if (target > arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return -1;
        }

        private static int ans(int[] arr, int target)
        {
            //find the range 
            return -1;
        }
    }
}
