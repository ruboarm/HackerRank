// Problem:   https://www.hackerrank.com/challenges/flipping-bits/problem


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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string binary = Convert.ToString(n, 2);

        StringBuilder fullBinary = new StringBuilder(32);
        if (binary.Length < 32)
        {
            for (int b = 0; b < 32 - binary.Length; b++)
            {
                fullBinary.Append(0);
            }
        }
        fullBinary.Append(binary);

        StringBuilder result = new StringBuilder(binary.Length);
        for (int b = 0; b < fullBinary.Length; b++)
        {
            if (fullBinary[b] == '1')
                result.Append(0);
            else
                result.Append(1);
        }

        int output = Convert.ToInt32(result.ToString(), 2);

        double sum = 0;
        for (int s = 0; s < result.Length; s++)
        {
            if (result[s] == '1')
                sum += Math.Pow(2, result.Length - s - 1);
        }

        return (long)sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
