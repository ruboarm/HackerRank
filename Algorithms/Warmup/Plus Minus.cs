// Problem:   https://www.hackerrank.com/challenges/plus-minus/problem


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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double count = arr.Count;
        var plus = arr.Where(a => a > 0).ToList();
        var minus = arr.Where(a => a < 0).ToList();
        var zero = arr.Where(a => a == 0).ToList();

        Console.WriteLine(Convert.ToDecimal(plus.Count / count).ToString("N6"));
        Console.WriteLine(Convert.ToDecimal(minus.Count / count).ToString("N6"));
        Console.WriteLine(Convert.ToDecimal(zero.Count / count).ToString("N6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
