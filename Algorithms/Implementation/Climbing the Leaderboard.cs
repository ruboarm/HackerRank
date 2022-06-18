// Problem:   https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem


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
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        // Define List<int> for return
        List<int> ranks = new List<int>();
        
        // Remove duplicates, in order to use a loop
        List<int> rankedunique = ranked.Distinct().ToList();
        
        // Define start index for rank loop
        int i = rankedunique.Count-1;
        
        // Find ranks for each
        for(int j=0; j<player.Count; j++){
            var currentPlayer = player[j];
            
            // Define check for setting the value true when the rank found
            bool rankFound = false;
			// Loop through ranks to find needed rank for current player
			// and set rankFound=true when it's found
            while(!rankFound && i>=0){
                var currentRank = rankedunique[i];
                
                // Increase the rank by 2, as index starts from 0
                // and it must be next rank
                if(currentPlayer<currentRank){
                    ranks.Add(i+2);
                    rankFound=true;
                }
                // Increase the rank by 1, as index starts from 0
                // and it must be the same rank
                else if(currentPlayer==currentRank){
                    ranks.Add(i+1);
                    rankFound=true;
                }
                else{
                    i--;
                }
            }
            
            // If still rank not found, the value is beager the max rank value, so in this case it is "rank 1"
            if(!rankFound){
                ranks.Add(1);
            }
        }
        
        return ranks;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
