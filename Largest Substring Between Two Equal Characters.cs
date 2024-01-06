// 1624. Largest Substring Between Two Equal Characters
// Easy
// 1.3K
// 60
// Companies
// Given a string s, return the length of the longest substring between two equal characters, excluding the two characters. If there is no such substring return -1.

// A substring is a contiguous sequence of characters within a string.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int res = -1;

        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {

                res = Math.Max(i - map[s[i]] - 1, res);
            }
            else
            {
                map.Add(s[i], i);
            }
        }
        return res;

    }
}