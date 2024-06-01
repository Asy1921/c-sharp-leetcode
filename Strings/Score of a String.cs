// 3110.Score of a String
// Solved
// Easy
// Topics
// Companies
// Hint
// You are given a string s. The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.

// Return the score of s.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int ScoreOfString(string s)
    {
        int prev = s[0];
        int sum = 0;
        for (int i = 1; i < s.Length; i++)
        {
            sum += Math.Abs(prev - s[i]);
            prev = s[i];
        }
        return sum;
    }
}