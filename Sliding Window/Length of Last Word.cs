// 58.Length of Last Word
// Solved
// Easy
// Topics
// Companies
// Given a string s consisting of words and spaces, return the length of the last word in the string.

// A word is a maximal 
// substring
//  consisting of non-space characters only.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Split(" ");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (!String.IsNullOrWhiteSpace(words[i]))
            {
                return words[i].Length;
            }
        }
        return 0;
    }
}