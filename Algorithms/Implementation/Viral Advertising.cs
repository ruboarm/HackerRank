// Problem:   https://www.hackerrank.com/challenges/strange-advertising/problem


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
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {
        // Define the variables
        int totalLikes = 0;
        int shares = 0;
        int likes = 0;
        
        // Loop through given days count
        for(int i=1; i<=n; i++){
            // First day shares=5 else likes*3
            shares = i ==1 ? 5 : likes * 3;
            likes = shares / 2;
            
            // Increase total likes by the number of "likes"
            totalLikes += likes;
        }
        
        return totalLikes;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
