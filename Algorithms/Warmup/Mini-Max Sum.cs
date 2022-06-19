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
        if (arr.Count > 0){
            // First of all convert array to Int64 list
            List<Int64> arr64 = arr.Select(v => Convert.ToInt64(v)).ToList();
            // Get the SUM of array values
            Int64 sumMax = arr64.Sum();

            // Print SUM-MAX and SUM-MIN
            Console.WriteLine((sumMax - arr64.Max()) + " " + (sumMax - arr64.Min()));
        }
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
