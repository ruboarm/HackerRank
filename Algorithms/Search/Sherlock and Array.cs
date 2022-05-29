// Problem:   https://www.hackerrank.com/challenges/sherlock-and-array/problem


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
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string balancedSums(List<int> arr)
    {
        int count = arr.Count;

        if (count == 1 || count == 0)
            return "YES";

        if (count == 2)
            if (arr[0] != 0)
                return "NO";

        int leftSum = 0;
        int rightSum = 0;
        int sum = arr.Sum();

        for (int i = 0; i < count / 2 + 1; i++)
        {
            if (leftSum == (sum - arr[i]) / 2 || rightSum == (sum - arr[count - i - 1]) / 2)
                return "YES";
            else
            {
                leftSum += arr[i];
                rightSum += arr[count - i - 1];
            }
        }

        return "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
