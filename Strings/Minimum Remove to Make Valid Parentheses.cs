// 1249. Minimum Remove to Make Valid Parentheses
// Solved
// Medium
// Topics
// Companies
// Hint
// Given a string s of '(' , ')' and lowercase English characters.

// Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions ) so that the resulting parentheses string is valid and return any valid string.

// Formally, a parentheses string is valid if and only if:

// It is the empty string, contains only lowercase characters, or
// It can be written as AB (A concatenated with B), where A and B are valid strings, or
// It can be written as (A), where A is a valid string.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string MinRemoveToMakeValid(string s)
    {
        List<char> res1 = new();
        int cnt = 0;
        foreach (char c in s)
        {
            if (c == ')')
            {
                if (cnt > 0)
                {
                    res1.Add(c);
                    cnt--;
                }
            }
            else if (c == '(')
            {
                cnt++;
                res1.Add(c);
            }
            else
                res1.Add(c);
        }
        List<char> res2 = new();
        res1.Reverse();
        foreach (char c in res1)
        {
            if (c == '(' && cnt > 0)
            {
                cnt--;
            }
            else
            {
                res2.Add(c);
            }

        }
        res2.Reverse();
        return new string(res2.ToArray());
    }
}