// 1758. Minimum Changes To Make Alternating Binary String
// Easy
// 1.2K
// 32
// Companies
// You are given a string s consisting only of the characters '0' and '1'. In one operation, you can change any '0' to '1' or vice versa.

// The string is called alternating if no two adjacent characters are equal. For example, the string "010" is alternating, while the string "0100" is not.

// Return the minimum number of operations needed to make s alternating.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public int MinOperations(string s)
    {
        int ops1 = 0;
        int ops0 = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (s[i] == '0')
                {
                    ops1++;
                }
                else
                {
                    ops0++;
                }
            }
            else
            {
                if (s[i] == '1')
                {
                    ops1++;
                }
                else
                {
                    ops0++;
                }
            }
        }

        return Math.Min(ops0, ops1);
    }
}