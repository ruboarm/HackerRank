// Problem:   https://www.hackerrank.com/challenges/electronics-shop/problem


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        // Define list p=for possible variants (combinations)
        List<int> variants = new List<int>();
        
        // Loop through keyboards
        for(int k=0; k<keyboards.Length; k++){
            // Loop through drives
            for(int d=0; d<drives.Length; d++){
                // Define variable for counting
                int count=1;
                
                // Define variable for sum
                int sum = keyboards[k] + drives[d];
                
                // Increase total if sum of both <= given budget
                if(sum<=b){
                    count++;
                }
                
                // If both devices are included include sum into total
                if(count==2)
                    variants.Add(sum);
            }
        } 
        
        return variants.Count!=0 ? variants.Max() : -1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
