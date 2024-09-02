using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class Solution
    {
        public int solution(int X,int Y,int D)
        {
            double result=((double) Y-(double)X)/(double)D;
            var count = result % 1 == 0 ? (int)result : result + 1;
            return (int)count;
        }
    }
}
