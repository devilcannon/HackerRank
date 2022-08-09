using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class TwoDimmensionArrays
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            List<int> results = new List<int>();

            for (int rows = 0; rows != 4; rows++)
            {
                for (int columns = 0; columns != 4; columns++)
                {
                    results.Add(GetValue(rows, columns, arr));
                }
            }
            var nums = results;
            nums.Sort();
            return nums[nums.Count-1];
        }

        private static int GetValue(int indexRow,int indexColumn, List<List<int>> arr)
        {
            int count = 0;
            bool firstIteraction = true;
            for (int rows = indexRow; rows != indexRow+3; rows++)
            {
                if (firstIteraction) {
                    for (int columns = indexColumn; columns != indexColumn + 3; columns++)
                    {
                        count += arr[rows][columns];
                    }
                    firstIteraction = false;
                }
                else
                {
                    List<int> val = new List<int>();
                    for (int columns = indexColumn; columns != indexColumn + 3; columns++)
                    {
                        val.Add(arr[rows][columns]);
                    }
                    count += val[1];
                    firstIteraction = true;
                }
            }
            return count;
        }

    }
}
