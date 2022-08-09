using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class DynamicArray
    {
        /*
        * Complete the 'dynamicArray' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. 2D_INTEGER_ARRAY queries
        */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAnswer = 0;
            int[,] arr = new int[n,n];
            List<int> lastValues = new List<int>();
            int lastOne = queries.Count;
            for(int x = 0; x != queries.Count; x++)
            {
                lastValues.Add(queries[x][lastOne - 2]);
            }

            List<int> answers = new List<int>();
            //Process
            
            return answers;
        }
    }
}
