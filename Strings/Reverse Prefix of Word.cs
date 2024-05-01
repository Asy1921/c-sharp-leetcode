// 2000.Reverse Prefix of Word
// Solved
// Easy
// Topics
// Companies
// Hint
// Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.

// For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
// Return the resulting string.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string ReversePrefix(string word, char ch)
    {
        if (!word.Contains(ch))
        {
            return word;
        }
        string str1 = "";
        string str2 = "";
        for (int i = 0; i < word.Length; i++)
        {
            str1 += word[i];
            if (word[i] == ch)
            {
                i++;
                while (i < word.Length)
                {
                    str2 += word[i];
                    i++;
                }
            }
        }

        return new string(str1.Reverse().ToArray()) + str2;
    }
}