// 1544. Make The String Great
// Solved
// Easy
// Topics
// Companies
// Hint
// Given a string s of lower and upper case English letters.

// A good string is a string which doesn't have two adjacent characters s[i] and s[i + 1] where:

// 0 <= i <= s.length - 2
// s[i] is a lower-case letter and s[i + 1] is the same letter but in upper-case or vice-versa.
// To make the string good, you can choose two adjacent characters that make the string bad and remove them. You can keep doing this until the string becomes good.

// Return the string after making it good. The answer is guaranteed to be unique under the given constraints.

// Notice that an empty string is also good.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string MakeGood(string s)
    {
        List<char> res = new() { s[0] };
        for (int i = 1; i < s.Length; i++)
        {
            if (res.Count > 0)
                Console.WriteLine(res[res.Count - 1] + ":" + s[i]);
            if (res.Count > 0 && Math.Abs(res[res.Count - 1] - s[i]) == 32)
            {
                Console.WriteLine(Math.Abs(res[res.Count - 1] - s[i]) == 32);
                res.RemoveAt(res.Count - 1);
            }
            else
            {
                res.Add(s[i]);
            }
        }
        return new string(res.ToArray());
    }
}