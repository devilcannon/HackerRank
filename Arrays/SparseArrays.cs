using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Arrays
{
    public static class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> value = new List<int>();
            for(int x = 0; x != queries.Count; x++)
            {
                int var = (from string val in strings
                           where val == queries[x]
                           select val).Count();
                value.Add(var);
            }
            return value;
        }

    }
}
