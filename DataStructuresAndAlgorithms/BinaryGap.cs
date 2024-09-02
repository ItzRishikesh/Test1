using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class BinaryGap
    {
        public int BinaryGapSol(int N)
        {
            int maxGap = 0; 
            int lastPosition = -1;

            for (int i = 0; N > 0; i++)
            {
                if ((N & 1) == 1)
                { 
                    if (lastPosition != -1)
                    { 
                        maxGap = Math.Max(maxGap, i - lastPosition);
                    }
                    lastPosition = i; 
                }
                N >>= 1; 
            }

            return maxGap;
        }

    }
}
