using HackerRank.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank.Algorithms;
using System.Diagnostics;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region time
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            #endregion

            //Work here!
            int[] key = {40,50,60};
            int[] drives = {5,8,12};

            List<int> ranked = new List<int>() { 1,3,1,3,1,4,1,3,2,5,5,5,5,1,1,5,5,1,5,2,5,5,5,5,5};
            Console.WriteLine(Implementation.UtopianTree(5));


            #region Default
            stopwatch.Stop();
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Time elapsed: {0} ms",stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
            #endregion
        }

        
    }
}
