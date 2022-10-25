using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HackerRank.Algorithms
{
    public static class Implementation
    {
        /*
        * Complete the 'gradingStudents' function below.
         *
         *HackerLand University has the following grading policy:

            Every student receives a  in the inclusive range from  to .
            Any  less than  is a failing grade.
            Sam is a professor at the university and likes to round each student's  according to these rules:

            If the difference between the  and the next multiple of  is less than , round  up to the next multiple of .
            If the value of  is less than , no rounding occurs as the result will still be a failing grade.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
        */
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> results = new List<int>();
            List<int> FiveMultiplers = new List<int>();
            for (int x = 1; x != 101; x++)
            {
                if ((x % 5)==0)
                {
                    FiveMultiplers.Add(x);
                }
            }
            foreach(int val in grades)
            {
                if (val < 38)
                {
                    results.Add(val);
                }
                else
                {
                    int closest = FiveMultiplers.Aggregate((x, y) => Math.Abs(x - val) < Math.Abs(y - val) ? x : y);
                    if (closest < val)
                    {
                        results.Add(val);
                    }
                    else
                    {
                        results.Add(closest);
                    }
                }
            }
            return results;
        }

        /*
         * Complete the 'kangaroo' function below.
         *
         * You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a 
         * number line ready to jump in the positive direction (i.e, toward positive infinity).
           The first kangaroo starts at location  and moves at a rate of  meters per jump.
           The second kangaroo starts at location  and moves at a rate of  meters per jump.
           You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.
            If it is possible, return YES, otherwise return NO.
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER x1
         *  2. INTEGER v1
         *  3. INTEGER x2
         *  4. INTEGER v2
         */
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            const int iteractions = 10000;
            for(int z = 0; z != iteractions; z++){
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        /*
         * Complete the 'getTotalX' function below.
         *
         *There will be two arrays of integers. Determine all integers that satisfy the following two conditions:
          The elements of the first array are all factors of the integer being considered
          The integer being considered is a factor of all elements of the second array
          These numbers are referred to as being between the two arrays. Determine how many such numbers exist.
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int min = a[0], max = b[^1];
            //Missing!
            return 0;
        }

        /*
       * Complete the 'countApplesAndOranges' function below.
       *
       * The function accepts following parameters:
       *  1. INTEGER s
       *  2. INTEGER t
       *  3. INTEGER a
       *  4. INTEGER b
       *  5. INTEGER_ARRAY apples
       *  6. INTEGER_ARRAY oranges
       */
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0, orangesCount = 0;
            int counter;
            foreach (int x in apples)
            {
                counter = a;
                counter += x;
                if (counter >= s && counter <= t)
                {
                    applesCount++;
                }
            }
            foreach (int x in oranges)
            {
                counter = b;
                counter += x;
                if (counter >= s && counter <= t)
                {
                    orangesCount++;
                }
            }
            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }


        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */
        public static List<int> BreakingRecords(List<int> scores)
        {
            int tempMin, tempMax,minCount = 0,maxCount = 0;
            tempMin = tempMax = scores[0];
            for (int x = 1; x != scores.Count; x++)
            {
                if(scores[x] < tempMin)
                {
                    tempMin = scores[x];
                    minCount++;
                }else if(scores[x] > tempMax)
                {
                    tempMax = scores[x];
                    maxCount++;
                }
            }
            return new List<int> { maxCount, minCount };
        }

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         * Given an array of integers, where all elements but one occur twice, find the unique element.
         */

        /*
         Find the median from an integer list
         */
        public static int FindMedian(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count / 2];
        }

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         * 
         * Given an array of integers, where all elements but one occur twice, find the unique element.
         */
        public static int Lonelyinteger(List<int> a)
        {
            var q = a.GroupBy(x => x)
                .OrderBy(x=> x.Count());
            foreach (var x in q)
            {
                return x.Key;
            }
            return 0;
        }

        /*
        * Complete the 'countingSort' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts INTEGER_ARRAY arr as parameter.
        * 
        * Given a list of integers, count and return the number of times each value appears as an array of integers.
        */
        public static List<int> CountingSort(List<int> arr)
        {
            //Paso 1: Definir el mayor valor de la lista
            List<int> result = new List<int>();
            for(int i = 0; i !=100; i++)
            {
                result.Add(0);
            }
            foreach(int x in arr)
            {
                result[x]++;
            }
            return result;
        }

        
    }
}
