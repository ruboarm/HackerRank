// Problem:   https://www.hackerrank.com/challenges/picking-numbers/problem


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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        var asclist = a.OrderBy(l=>l).ToList();
        
        // Define the return parameter
        int longest = 0;
        
        // Start checking
        for(int i=0; i<asclist.Count; i++){
            // Define subarray length counter
            int currentLength = 1;
            
            // Loop through next values in an array and find corresponding values
            for(int j=i+1; j<asclist.Count; j++){
                // Check the difference to meet the condition
                if(Math.Abs(asclist[j]-asclist[i])<=1){
                    // Increase the current subarray length counter
                    currentLength++;
                }
                // If condition isn't meat, exit loop
                else
                    break;
            }
            
            // Get the maximum of 2 values
            longest = Math.Max(longest, currentLength);
        }
        
        return longest;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
