using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class TwoSum
    {
        public int[] findTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (keyValuePairs.ContainsKey(complement))
                {
                    return new int[] { keyValuePairs[complement], i };
                }
                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs.Add(nums[i], i);
                }
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
