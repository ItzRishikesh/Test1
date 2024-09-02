using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Graph
{
    public class BasicGraph
    {
        private readonly int totalVertices;
        private readonly LinkedList<int>[] linkedListArray;

        public BasicGraph(int n)
        {
            totalVertices = n;
            linkedListArray=new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
                linkedListArray[i]=new LinkedList<int>();
        }
        public void addEdge(int vertex, int adVertex)
        {
            linkedListArray[vertex].AddLast(adVertex);
        }
        public void printAdjanceyList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < linkedListArray.Length; i++)
            {
                stringBuilder.Append("[Node value" + i + " with neighbors.");
                foreach (var item in linkedListArray[i])
                {
                    stringBuilder.Append(" -> "+item);
                }
                stringBuilder.Append(" ]\n");
            }
            Console.WriteLine(stringBuilder.ToString());
        }
        public void CreateAdjunceyMatrix(BasicGraph basicGraph)
        {
            int?[,] adjunceyMatrix = new int?[basicGraph.totalVertices, basicGraph.totalVertices];
            for (int i = 0; i < basicGraph.totalVertices; i++)
            {
                var parentNode = linkedListArray[i];
                for (global::System.Int32  j = 0;  j < basicGraph.totalVertices;  j++)
                {
                    if (i!=j)
                    {
                        var arc = parentNode.Find(j);
                        if (arc!=null)
                        {
                            adjunceyMatrix[i, j] = 1;
                        }
                    }
                }
            }
            printAdjunceyMatrix(adjunceyMatrix,basicGraph.totalVertices);
        }
        public void printAdjunceyMatrix(int?[,] adjuncyMatrix, int count)
        {

        }
    }
}
