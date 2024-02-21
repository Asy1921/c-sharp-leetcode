// 2390. Removing Stars From a String
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given a string s, which contains stars *.

// In one operation, you can:

// Choose a star in s.
// Remove the closest non-star character to its left, as well as remove the star itself.
// Return the string after all stars have been removed.

// Note:

// The input will be generated such that the operation is always possible.
// It can be shown that the resulting string will always be unique.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string RemoveStars(string str)
    {
        Stack<char> s = new Stack<char>();

        foreach (char c in str)
        {
            if (c == '*')
            {
                if (s.Count > 0)
                {
                    s.Pop();
                }
            }
            else
            {
                s.Push(c);
            }
        }
        char[] charArray = String.Join("", s).ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}