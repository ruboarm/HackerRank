// Problem:   https://www.hackerrank.com/challenges/mini-max-sum/problem


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
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        List<long> sums = new List<long>(arr.Count);

        int summax = arr.Sum();
        for (int i = 0; i < arr.Count; i++)
        {
            sums.Add(Convert.ToInt64(summax - arr[i]));
        }

        if (sums.Count > 0)
            Console.WriteLine(sums.Min() + " " + sums.Max());
        else
            Console.WriteLine("");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
