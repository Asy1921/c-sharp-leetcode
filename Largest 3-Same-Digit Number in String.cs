// 2264. Largest 3-Same-Digit Number in String
// Easy
// 774
// 37
// Companies
// You are given a string num representing a large integer. An integer is good if it meets the following conditions:

// It is a substring of num with length 3.
// It consists of only one unique digit.
// Return the maximum good integer as a string or an empty string "" if no such integer exists.

// Note:

// A substring is a contiguous sequence of characters within a string.
// There may be leading zeroes in num or a good integer.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string LargestGoodInteger(string num)
    {
        int res = -1;
        for (int i = 0; i <= num.Length - 3; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
            {
                res = Math.Max(res, num[i] - '0');
                i = i + 2;
            }
        }
        if (res == -1)
        { return ""; }
        else
        {
            return res.ToString() +
             res.ToString() +
             res.ToString();
        }
    }
}