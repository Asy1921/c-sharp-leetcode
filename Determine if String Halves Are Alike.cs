
// Code
// Testcase
// Test Result
// Test Result
// 1704. Determine if String Halves Are Alike
// Solved
// Easy
// Topics
// Companies
// Hint
// You are given a string s of even length. Split this string into two halves of equal lengths, and let a be the first half and b be the second half.

// Two strings are alike if they have the same number of vowels ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains uppercase and lowercase letters.

// Return true if a and b are alike. Otherwise, return false.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool HalvesAreAlike(string s)
    {
        HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (vowels.Contains(s[i]))
            {
                count1++;

            }
        }
        for (int i = s.Length / 2; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                count2++;

            }
        }

        return count1 == count2;

    }
}
