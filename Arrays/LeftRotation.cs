using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class LeftRotation
    {
        public static List<int> rotateLeft(int d, List<int> arr)
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
