// Problem:   https://www.hackerrank.com/challenges/designer-pdf-viewer/problem


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
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        // Define dictionary for a-z letter indexing
        Dictionary<int, string> dict = new Dictionary<int, string>(26){
            {0, "a"},
            {1, "b"},
            {2, "c"},
            {3, "d"},
            {4, "e"},
            {5, "f"},
            {6, "g"},
            {7, "h"},
            {8, "i"},
            {9, "j"},
            {10, "k"},
            {11, "l"},
            {12, "m"},
            {13, "n"},
            {14, "o"},
            {15, "p"},
            {16, "q"},
            {17, "r"},
            {18, "s"},
            {19, "t"},
            {20, "u"},
            {21, "v"},
            {22, "w"},
            {23, "x"},
            {24, "y"},
            {25, "z"}
        };
        
        // Define default max value
        int max=1;
        // For each letter Loop through all heights to find the max of them
        foreach(var letter in word){
            // Find current letter index
            var dictVal = dict.FirstOrDefault(l=>l.Value==letter.ToString());
            // Get current letter height
            int val = h[dictVal.Key];
            // Compare max value with current height to get max of them
            if(val > max)
                max = val;
        }
        
        // Return the highlighted area size
        return max * word.Length;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
