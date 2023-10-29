// 17. Letter Combinations of a Phone Number
// Medium
// 17.4K
// 907
// Companies
// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

// A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<string> LetterCombinations(string digits)
    {
        List<string> res = new List<string>();
        Dictionary<char, string> lettersMap = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

        void backtrack(string cur)
        {
            if (cur.Length == digits.Length)
            {
                res.Add(cur);
                return;
            }
            int len = cur.Length;
            foreach (char c in lettersMap[digits[len]])
            {
                backtrack(cur + c);
            }
        }
        if (digits == "")
        {
            return res;
        }
        backtrack("");
        return res;
    }
}