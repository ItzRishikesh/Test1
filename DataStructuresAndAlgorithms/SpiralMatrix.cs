using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SpiralMatrix
    {
        /// <summary>
        /// Given an m x n matrix, return all elements of the matrix in spiral order.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> res = new List<int>();
            if (matrix.Length == 0)
                return res;
            int rowBegin = 0, rowEnd = matrix.Length - 1, colBegin = 0, colEnd = matrix[0].Length - 1;
            while (rowBegin <= rowEnd && colBegin <= colEnd)
            {
                // Traverse Right
                for (int j = colBegin; j <= colEnd; j++)
                {
                    res.Add(matrix[rowBegin][j]);
                }
                rowBegin++;

                // Traverse Down
                for (int j = rowBegin; j <= rowEnd; j++)
                {
                    res.Add(matrix[j][colEnd]);
                }
                colEnd--;

                if (rowBegin <= rowEnd)
                {
                    // Traverse Left
                    for (int j = colEnd; j >= colBegin; j--)
                    {
                        res.Add(matrix[rowEnd][j]);
                    }
                }
                rowEnd--;

                if (colBegin <= colEnd)
                {
                    // Traverse Up
                    for (int j = rowEnd; j >= rowBegin; j--)
                    {
                        res.Add(matrix[j][colBegin]);
                    }
                }
                colBegin++;
            }

            return res;
        }
    }
}
