using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace minMaxSumHR
{
    class Program
    {



        class Result
        {

            /*
             * Complete the 'miniMaxSum' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void miniMaxSum(List<int> arr)
            {

                double minSum = 0;
                double maxSum = 0;
                minSum = Sum(arr, true);
                maxSum = Sum(arr, false);
                Console.WriteLine($"{minSum} {maxSum}");

            }
            public static double Sum(List<int> arr, bool isMin)
            {
                double sum = isMin ? long.MaxValue : 0;//
                var values = new List<double>(arr.Select(v => (double)v));
                for (var i = 0; i < values.Count; i++)
                {
                    values.RemoveAt(i);
                    if (isMin)
                    {
                        sum = values.Sum() < sum ? values.Sum() : sum;
                    }
                    else
                    {
                        sum = values.Sum() > sum ? values.Sum() : sum;
                    }
                    values = new List<double>(arr.Select(v => (double)v));
                }
                return sum;
            }




        class Solution
        {
                public static void Main(string[] args)
                {
                    miniMaxSum list = new miniMaxSum();
                    miniMaxSum(list);

                    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                    // miniMaxSum(arr);

                }
            }
        }
    }
}

