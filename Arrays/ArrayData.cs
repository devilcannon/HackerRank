using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Arrays
{
    public static class ArrayData
    {
        /*
        * Complete the 'arrayManipulation' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. 2D_INTEGER_ARRAY queries
        */
        public static long ArrayManipulation(int n, List<List<int>> queries)
        {
            long value = 0;
            int lastAnswer = 0;
            int[,] arr = new int[n, n];
            return value;
        }

        public static List<int> ReverseArray(List<int> a)
        {
            List<int> value = new List<int>();
            for (int x = a.Count; x != 0; x--)
            {
                value.Add(a[x - 1]);
            }
            return value;
        }

        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            List<int> value = new List<int>();
            for (int x = 0; x != queries.Count; x++)
            {
                int var = (from string val in strings
                           where val == queries[x]
                           select val).Count();
                value.Add(var);
            }
            return value;
        }

        public static int HourglassSum(List<List<int>> arr)
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
            return nums[nums.Count - 1];
        }

        private static int GetValue(int indexRow, int indexColumn, List<List<int>> arr)
        {
            int count = 0;
            bool firstIteraction = true;
            for (int rows = indexRow; rows != indexRow + 3; rows++)
            {
                if (firstIteraction)
                {
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

        public static List<int> RotateLeft(int d, List<int> arr)
        {
            List<int> tmpArr = arr;
            for (int x = 0; x != d; x++)
            {
                int value = tmpArr[0];
                tmpArr.RemoveAt(0);
                tmpArr.Add(value);
            }
            return tmpArr;
        }


    }
}
