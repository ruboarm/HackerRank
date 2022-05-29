// Problem:   https://www.hackerrank.com/challenges/caesar-cipher-1/problem


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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        StringBuilder alphabet = new StringBuilder();
        for (char a = 'a'; a <= 'z'; a++)
            alphabet.Append(a);

        int ok = k > 26 ? k % 26 : k;

        string alp = alphabet.ToString();
        string chiper = alp.Substring(ok, alp.Length - ok) + alp.Substring(0, ok);

        StringBuilder test = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            var isUpper = Char.IsUpper(s[i]);
            var lower = Char.IsUpper(s[i]) ? s[i].ToString().ToLower() : s[i].ToString();

            if (Char.IsLetter(s[i]))
            {
                int index = alp.IndexOf(lower);
                var letter = isUpper ? chiper[index].ToString().ToUpper() : chiper[index].ToString();
                test.Append(letter);
            }
            else
                test.Append(s[i]);
        }

        return test.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
