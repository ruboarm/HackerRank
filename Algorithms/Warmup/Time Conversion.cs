// Problem:   https://www.hackerrank.com/challenges/time-conversion/problem


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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string ampm = s.Substring(s.Length - 2, 2);
        string time = s.Substring(0, s.Length - 2);

        List<string> list = time.Split(':').ToList();

        if (ampm == "AM")
            if (list[0]=="12")
                return "00:" + list[1] + ":" + list[2];
            else
                return list[0] + ":" + list[1] + ":" + list[2];
        else
            if (list[0] == "12")
            return "12:" + list[1] + ":" + list[2];
        else
            return (Convert.ToInt32(list[0]) + 12).ToString() + ":" + list[1] + ":" + list[2];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
