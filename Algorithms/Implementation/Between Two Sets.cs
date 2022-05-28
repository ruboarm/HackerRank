// Problem:   https://www.hackerrank.com/challenges/between-two-sets/problem


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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int totalXs = 0;
        int counter = 1;
        
        int amax = a.Max();
        int bmin = b.Min();
        
        int amaxwithcounter = amax * counter;
        
        while(amaxwithcounter <= bmin){
            var factorOfAll = true;
            
            foreach(var ai in a){
                if(amaxwithcounter % ai != 0){
                    factorOfAll = false;
                    break;
                }
            }
            
            if(factorOfAll){
                foreach(int bi in b){
                    if(bi % amaxwithcounter != 0){
                        factorOfAll = false;
                        break;
                    }
                }
            }
            
            if(factorOfAll)
                totalXs++;
            
            counter++;
            amaxwithcounter = amax * counter;
        }
        
        return totalXs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
