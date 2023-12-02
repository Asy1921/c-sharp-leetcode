// 1160. Find Words That Can Be Formed by Characters
// Easy
// 1.7K
// 164
// Companies
// You are given an array of strings words and a string chars.

// A string is good if it can be formed by characters from chars (each character can only be used once).

// Return the sum of lengths of all good strings in words.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int CountCharacters(string[] words, string chars)
    {
        int[] charArr = CountChars(chars);
        int res = 0;
        foreach (string s in words)
        {
            int[] strArr = CountChars(s);

            if (canFormWord(strArr, charArr))
            {
                res += s.Length;
            }
        }
        return res;
    }
    public int[] CountChars(string word)
    {
        int[] arr = new int[26];

        foreach (char c in word)
        {
            arr[c - 'a']++;
        }
        return arr;
    }

    public bool canFormWord(int[] w1, int[] w2)
    {
        for (int i = 0; i < 26; i++)
        {
            if (w1[i] > w2[i])
            {
                return false;
            }
        }
        return true;

    }
}