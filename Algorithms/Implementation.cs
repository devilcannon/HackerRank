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
        public static int GetTotalX(int[] a, int[] b)
        {
            int count = 0;
            for (int i = a[^1]; i <= b[0]; i++)
            {
                bool isFactor = true;
                foreach (int num in a)
                {
                    if (i % num != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }
                if (isFactor)
                {
                    foreach (int num in b)
                    {
                        if (num % i != 0)
                        {
                            isFactor = false;
                            break;
                        }
                    }
                }
                if (isFactor)
                {
                    count++;
                }
            }
            return count;
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

        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         */

        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /*
         * Complete the 'dayOfProgrammer' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER year as parameter.
         */

        public static string DayOfProgrammer(int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }
            else if ((year < 1918 && year % 4 == 0) || (year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))))
            {
                return "12.09." + year;
            }
            else
            {
                return "13.09." + year;
            }
        }

        /*
         * Complete the 'pageCount' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER p
         */

        public static int PageCount(int n, int p)
        {
            int fromFront = p / 2;
            int fromBack = n / 2 - p / 2;
            return Math.Min(fromFront, fromBack);
        }

        /*
         * Complete the getMoneySpent function below.
         */
        public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxSpent = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int total = keyboards[i] + drives[j];
                    if (total <= b && total > maxSpent)
                    {
                        maxSpent = total;
                    }
                }
            }
            return maxSpent;
        }

        // Complete the catAndMouse function below.
        public static string CatAndMouse(int x, int y, int z)
        {
            int catADistance = Math.Abs(x - z);
            int catBDistance = Math.Abs(y - z);
            if (catADistance < catBDistance)
            {
                return "Cat A";
            }
            else if (catBDistance < catADistance)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }

        /*
         * Complete the 'formingMagicSquare' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY s as parameter.
         */
        public static int FormingMagicSquare(List<List<int>> s)
        {
            int[][][] possibleMagicSquares = new int[][][]
            {
                new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
                new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
                new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } },
                new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } },
                new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } },
                new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } },
                new int[][] { new int[] { 6, 7, 2 }, new int[] { 1,5 ,9},new int[]{8 ,3 ,4}},
                new int[][]{new int[]{2 ,7 ,6},new int[]{9 ,5 ,1},new int[]{4 ,3 ,8}}
            };
            int minCost = Int32.MaxValue;
            for (int i = 0; i < possibleMagicSquares.Length; i++)
            {
                int currentCost = 0;
                for (int j = 0; j < possibleMagicSquares[i].Length; j++)
                {
                    for (int k = 0; k < possibleMagicSquares[i][j].Length; k++)
                    {
                        currentCost += Math.Abs(s[j][k] - possibleMagicSquares[i][j][k]);
                    }
                }
                minCost = Math.Min(minCost, currentCost);
            }
            return minCost;
        }

        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */
        public static int PickingNumbers(List<int> a)
        {
            int maxCount = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[j] == a[i] || a[j] == a[i] + 1)
                    {
                        currentCount++;
                    }
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        /*
         * Complete the 'climbingLeaderboard' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY ranked
         *  2. INTEGER_ARRAY player
         */
        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            int[] ranks = new int[player.Count];
            int[] distinctScores = ranked.Distinct().ToArray();
            int i = distinctScores.Length - 1;
            for (int j = 0; j < player.Count; j++)
            {
                while (i >= 0)
                {
                    if (player[j] >= distinctScores[i])
                    {
                        i--;
                    }
                    else
                    {
                        ranks[j] = i + 2;
                        break;
                    }
                }
                if (i < 0)
                {
                    ranks[j] = 1;
                }
            }
            return ranks.ToList();
        }

        /*
         * Complete the 'hurdleRace' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY height
         */
        public static int HurdleRace(int k, List<int> height)
        {
            int maxHurdle = height.Max();
            if (maxHurdle > k)
            {
                return maxHurdle - k;
            }
            else
            {
                return 0;
            }
        }

        /*
         * Complete the 'designerPdfViewer' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY h
         *  2. STRING word
         */
        public static int DesignerPdfViewer(List<int> h, string word)
        {
            int maxHeight = 0;
            foreach (char c in word)
            {
                int index = c - 'a';
                if (h[index] > maxHeight)
                    maxHeight = h[index];
            }
            return maxHeight * word.Length;
        }

        /*
         * Complete the 'utopianTree' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */
        public static int UtopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    height *= 2;
                else
                    height += 1;
            }
            return height;
        }

        /*
         * Complete the 'angryProfessor' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY a
         */
        public static string AngryProfessor(int k, List<int> a)
        {
            int onTimeStudents = 0;
            foreach (int arrivalTime in a)
            {
                if (arrivalTime <= 0)
                    onTimeStudents++;
            }
            return onTimeStudents < k ? "YES" : "NO";
        }


    }
}
