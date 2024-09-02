using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class MergeStringAlternately
    {
        public string Solution(string workd1,string word2)
        {
            int firstWordLength=workd1.Length;
            int secondWordLength=word2.Length;
            int a=0, b = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int word = 1;
            while (a<firstWordLength && b<secondWordLength)
            {
                if (word==1)
                {
                    stringBuilder.Append(workd1[a]);
                    a += 1;
                    word = 2;
                }
                else
                {
                    stringBuilder.Append(word2[b]);
                    b += 1;
                    word = 1;
                }
            }
            while (a<firstWordLength)
            {
                stringBuilder.Append(workd1[a]);
                a += 1;
            }
            while (b < secondWordLength)
            {
                stringBuilder.Append(word2[b]);
                b += 1;
            }
            return stringBuilder.ToString();

        }
    }
}
