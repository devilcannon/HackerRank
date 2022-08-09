using HackerRank.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> v1 = new List<int>()
            {
                1,0,5
            };List<int> v2 = new List<int>()
            {
                1,1,7
            };List<int> v3 = new List<int>()
            {
                1,0,3
            };List<int> v4 = new List<int>()
            {
                2,1,0
            };List<int> v5 = new List<int>()
            {
                2,1,1
            };

            List<List<int>> queries = new List<List<int>>();
            queries.Add(v1);
            queries.Add(v2);
            queries.Add(v3);
            queries.Add(v4);
            queries.Add(v5);

            DynamicArray.dynamicArray(2,queries);
            #region Default
            Console.WriteLine("END");
            Console.ReadKey();
            #endregion
        }
    }
}
