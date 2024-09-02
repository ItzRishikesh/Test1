using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class RomanToInt
    {
        public int roamnTOInt(string roman)
        {
            Dictionary<char, int> map = new Dictionary<char, int>() 
            { 
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            int currentSum = 0, i=0;

            while (i< roman.Length)
            {
                if (i< roman.Length - 1 && map[roman[i]]< map[roman[i+1]])
                {
                    currentSum += map[roman[i + 1]] - map[roman[i]];
                    i += 2;
                }
                else
                {
                    currentSum += map[roman[i]];
                    i += 1;

                }
            }
            return currentSum;
        }
    }
}
