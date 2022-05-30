// Problem:   https://www.hackerrank.com/challenges/day-of-the-programmer/problem


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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        bool leapYear = year%4==0 ? true : false;
        
        // Calculate total days till September - 243
        int tillSeptember = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
        int mm = 9;
        
        if(leapYear)
            tillSeptember += 1;
            
        // 1918 was change year, so add 13 days
        if(year==1918)
            tillSeptember+=13; // 229/230
            
        int dd = 256-tillSeptember;
        
        return dd + ".0" + mm + "." + year;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
