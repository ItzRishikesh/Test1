using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class IsSubsequence
    {
        public bool Solution(string a ,string b)
        {
            if (a.Length==0 )
            
                return true;
            if(a.Length > b.Length)
                return false;
            int j = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[j])
                {
                    if (j==a.Length-1)
                    {
                        return true;
                    }
                    j += 1;
                }
            }
            return false;
        }
    }
}
