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
        
        // Loop through each player to find ranks
        for(int p=0; p<player.Count; p++){
			var currentPlayer = player[p];
			
			// Loop through leaderboard ranks and find ranks for each player
            for(int r=rankedunique.Count-1; r>=0; r--){
				var currentRank = rankedunique[r];
                // Increase the rank by 2, as index starts from 0
                // and it must be next rank
				if(currentPlayer<currentRank){
                    ranks.Add(r+1+1);
                    break;
                }
                // Increase the rank by 2, as index starts from 0
                // and it must be the same index
                else if(currentPlayer==currentRank){
                    ranks.Add(r+1);
                    break;
                }
                // The rank is out leaderboard, so it must be 1
                else if(currentPlayer>rankedunique[0]){
                    ranks.Add(1);
                    break;
                }
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
