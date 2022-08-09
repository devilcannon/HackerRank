using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class ReverseArray
    {

        public static List<int> reverseArray(List<int> a)
        {
            List<int> value = new List<int>();
            for(int x = a.Count; x != 0; x--)
            {
                value.Add(a[x - 1]);
            }
            return value;
        }
    }
}
