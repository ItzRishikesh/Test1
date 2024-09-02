using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SummaryRanges
    {
        //public IList<string> SummaryRanges(int[] nums)
        //{
        //    var ans = new List<string>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] - nums[i + 1] == 1)
        //        {
        //            ans.Add(nums[i].ToString());
        //        }
        //    }
        //}
        public static IList<string> GetSummaryRanges(int[] nums)
        {
            var ans = new List<string>();
            if (nums.Length == 0) return ans;

            int start = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                // Check if we are at the end of the array or there is a gap between current and next element
                if (i == nums.Length - 1 || nums[i + 1] - nums[i] > 1)
                {
                    if (start == nums[i])
                    {
                        ans.Add(start.ToString());
                    }
                    else
                    {
                        ans.Add(start + "->" + nums[i]);
                    }
                    // Update the start to the next number
                    if (i != nums.Length - 1)
                    {
                        start = nums[i + 1];
                    }
                }
            }

            return ans;
        }

    }

}
