// 678. Valid Parenthesis String
// Solved
// Medium
// Topics
// Companies
// Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.

// The following rules define a valid string:

// Any left parenthesis '(' must have a corresponding right parenthesis ')'.
// Any right parenthesis ')' must have a corresponding left parenthesis '('.
// Left parenthesis '(' must go before the corresponding right parenthesis ')'.
// '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool CheckValidString(string s)
    {
        int lMin = 0;
        int lMax = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                lMin++;
                lMax++;
            }
            else if (c == ')')
            {
                lMin--;
                lMax--;
            }
            else
            {
                lMin--;
                lMax++;
            }
            if (lMin < 0)
            {
                lMin = 0;
            }
            if (lMax < 0)
            {
                return false;
            }
        }
        return lMin == 0;
    }
}