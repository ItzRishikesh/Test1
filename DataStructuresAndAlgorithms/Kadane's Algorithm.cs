using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class KadanesAlgorithm
    {
        public static int FindMaximumSumOfArray(int[] nums)
        {
            //Edge Case handle
            if (nums is null || nums.Length == 0)
                throw new ArgumentException("Array can not be empty");
            int max_so_far = int.MinValue, max_ending_here = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max_ending_here += nums[i];
                if (max_so_far<max_ending_here)
                    max_so_far=max_ending_here;
                if (max_ending_here < 0)
                    max_ending_here = 0;
            }
            return max_so_far;
        }
    }
}
