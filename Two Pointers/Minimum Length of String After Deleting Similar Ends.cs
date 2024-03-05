
// Code
// Testcase
// Test Result
// Test Result
// 1750. Minimum Length of String After Deleting Similar Ends
// Solved
// Medium
// Topics
// Companies
// Hint
// Given a string s consisting only of characters 'a', 'b', and 'c'. You are asked to apply the following algorithm on the string any number of times:

// Pick a non-empty prefix from the string s where all the characters in the prefix are equal.
// Pick a non-empty suffix from the string s where all the characters in this suffix are equal.
// The prefix and the suffix should not intersect at any index.
// The characters from the prefix and suffix must be the same.
// Delete both the prefix and the suffix.
// Return the minimum length of s after performing the above operation any number of times (possibly zero times).
namespace LeetCodeProblems;

public partial class LCProblems
{
    public int MinimumLength(string s)
    {
        int length = s.Length;

        if (length <= 1)
        {
            return length;
        }

        int l = 0, r = length - 1;

        while (l < r && s[l] == s[r])
        {
            char ch = s[l];

            // Find the non-empty prefix
            while (l <= r && s[l] == ch)
            {
                l++;
            }

            // Find the non-empty suffix
            while (l <= r && s[r] == ch)
            {
                r--;
            }
        }

        return r - l + 1;
    }
}
