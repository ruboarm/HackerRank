// Problem: https://www.hackerrank.com/challenges/day-of-the-programmer/problem



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
        // Define total days near 256
        int tillSeptember = 31+28+31+30+31+30+31+31; // 243
        
        // In switch Year there was 13 days less, so extract 13 from total days
        if(year==1918)
            tillSeptember-=13;
        
        // Define leapYear variable
        bool leapYear = false;
        
        // Check leap year variants
        if(year<=1918)
            // Julian Calendar
            leapYear = year%4==0 ? true : false;
        else
            // Georgian Calendar
            leapYear = year%400==0 || (year%4==0 && year%100!=0) ? true : false;
        
        // If the Year is leap, increase number of days by 1
        if(leapYear)
            tillSeptember++;
        
        // Always the month is September (09)
        return (256-tillSeptember) + ".09." + year;
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
