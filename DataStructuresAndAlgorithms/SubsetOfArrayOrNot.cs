using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class SubsetOfArrayOrNot
    {
       public bool SubSet(int[] arr,int[] arr1)
        {
            HashSet<int> set = new HashSet<int>(); 

            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!set.Contains(arr1[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
