using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class RotateArray
    {
        public static int[][] RotatedArrayUsingTransver(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = i; j < arr.Length; j++)
                {
                    int temp = arr[i][j];
                    arr[i][j] = arr[j][i];
                    arr[j][i] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Reverse(arr[i]);
            }
            return arr;
        }
        
    }
}
