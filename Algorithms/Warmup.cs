using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class Warmup
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int firstResult = 0, secondResult = 0, index = 0;
            for (int x = 0; x != arr[0].Count; x++)
            {
                firstResult += arr[x][x];
            }
            for (int x = arr[1].Count - 1; x != -1; x--)
            {
                secondResult += arr[x][index];
                index++;
            }
            return firstResult > secondResult ? (firstResult - secondResult) : secondResult - firstResult;
        }

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void Staircase(int n)
        {
            int counter = 1;
            for (int x = n; x != 0; x--)
            {
                string value = new string('#', counter);
                string valu2 = new string(' ', x - 1);
                Console.WriteLine("{0}{1}", valu2, value);
                counter++;
            }
        }

        /*
        *    Given an array of integers, calculate the ratios of its elements that are positive, 
        *    negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
        *    Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, 
        *    though answers with absolute error of up to  are acceptable.
        */
        public static void PlusMinus(List<int> arr)
        {
            var dList = new decimal[] { 0, 0, 0 };//Positives, negatives, zeros
            foreach (int value in arr)
            {
                if (value > 0)
                {
                    dList[0]++;
                }
                else if (value < 0)
                {
                    dList[1]++;
                }
                else
                {
                    dList[2]++;
                }
            }
            foreach (decimal d in dList)
            {
                decimal current = d / arr.Count;
                Console.WriteLine(current.ToString("0.00000"));
            }
        }
        
        /*
        *Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly 
        *four of the five integers. Then print the respective minimum and maximum values as a single 
        *line of two space-separated long integers.
        */
        public static void MiniMaxSum(List<int> arr)
        {
            Int64 total = 0;
            arr.Sort();
            foreach (var x in arr)
            {
                total += x;
            }
            Console.WriteLine("{0} {1}", total - arr[^1], total - arr[0]);
        }

        /*
        * Complete the 'birthdayCakeCandles' function below.
        * You are in charge of the cake for a child's birthday. You have decided the cake will have one 
        * candle for each year of their total age. They will only be able to blow out the tallest of 
        * the candles. Count how many candles are tallest.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER_ARRAY candles as parameter.
        */

        public static int BirthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            int counter = 0;
            foreach(int x in candles)
            {
                if (x == candles[^1])
                {
                    counter++;
                }
            }
            return counter;
        }

        /*
        * Complete the 'timeConversion' function below.
        * Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        *  Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        *        - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        * The function is expected to return a STRING.
        * The function accepts STRING s as parameter.
        */
        public static string TimeConversion(string s)
        {
            DateTime.TryParse(s, out DateTime val);
            return val.ToString("HH:mm:ss");
        }

        /*
         * Complete the 'sockMerchant' function below.
         *
         *There is a large pile of socks that must be paired by color. 
         *Given an array of integers representing the color of each sock, 
         *determine how many pairs of socks with matching colors there are.
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */
        public static int SockMerchant(int n, List<int> ar)
        {
            int pairNumber = 0;
            var q = ar.GroupBy(x => x)
                .Select(x => x.Count());
            foreach (var x in q)
            {
                if (x > 1)
                {
                    int value = x;
                    if ((x % 2) != 0)
                    {
                        value--;
                    }
                    pairNumber += (value/2);
                }
            }
            return pairNumber;
        }

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */
        public static int CountingValleys(int steps, string path)
        {
            int marLevel = 0,valleyCount = 0;
            char[] arr = path.ToCharArray();
            foreach(char c in arr)
            {
                if (c == 'U')
                {
                    marLevel++;
                }
                else
                {
                    marLevel--;
                }
                if(marLevel == 0 && c=='U')
                {
                    valleyCount++;
                }
            }
            return valleyCount;
        }


        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */
        public static int JumpingOnClouds(List<int> c)
        {
            int jumpsCounter = 0,currentPosition = 0;
            while (currentPosition < c.Count-1)
            {
                currentPosition += 2;
                if (currentPosition > c.Count-1) 
                {
                    jumpsCounter++;
                    break;
                }
                if (c[currentPosition] == 1)
                {
                    currentPosition--;
                }
                jumpsCounter++;
            }
            return jumpsCounter;
        }

        /*
         * Complete the 'repeatedString' function below.
         *There is a string, , of lowercase English letters that is repeated infinitely 
         *many times. Given an integer, , find and print the number of letter a's in 
         *the first  letters of the infinite string.
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long RepeatedString(string s, long n)
        {
            return (n / s.Length) * s.Count(c => c == 'a') + s.Substring(0, (int)(n % (long)s.Length)).Count(c => c == 'a');

        }

    }
}
