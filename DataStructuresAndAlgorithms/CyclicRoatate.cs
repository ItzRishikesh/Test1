using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class CyclicRoatate
    {
        public int[] RotatedArray(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n; // In case k is greater than the length of the array
            Reverse(arr, 0, n - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, n - 1);
            return arr;
        }
        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        }
}
