// Problem:   https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem


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
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int beautifulDays(int i, int j, int k)
    {
        // Define variable for beautiful days
        int beautyDays = 0;
        
        // Loop through given days to find out how many days are beautiful
        for(int d=i; d<=j; d++){
            // Reverse the number
            int num=d;
            int reverse=0;
            int remainder=0;
            while (num > 0) {
                remainder = num % 10;  
                reverse = reverse * 10 + remainder;  
                num /= 10;  
            }
            
            // If their difference evenly devides by k, than increase beautyDays by 1
            if(Math.Abs(d-reverse)%k==0)
                beautyDays++;
        }
        
        return beautyDays;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
