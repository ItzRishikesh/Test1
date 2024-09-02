using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
   static internal class BalancedString
    {
        public static int balancedString(string s)
        {
            int n = s.Length;
            int k = n / 4;
            Dictionary<char, int> count = new Dictionary<char, int> { { 'Q', 0 }, { 'W', 0 }, { 'E', 0 }, { 'R', 0 } };

            foreach (char c in s.Where(count.ContainsKey))
            {
                count[c]++;
            }

            if (count['Q'] == k && count['W'] == k && count['E'] == k && count['R'] == k)
            {
                return 0;
            }

            int minLength = n;
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                count[s[right]]--;

                while (left < n && count['Q'] <= k && count['W'] <= k && count['E'] <= k && count['R'] <= k)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    count[s[left]]++;
                    left++;
                }
            }

            return minLength;
        }
    }
}
