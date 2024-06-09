// 1002.Find Common Characters
// Solved
// Easy
// Topics
// Companies
// Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<string> CommonChars(string[] words)
    {
        List<string> res = new();
        string s = words[0];

        foreach (char t in s)
        {
            string c = t.ToString();
            res.Add(c);
            for (int i = 1; i < words.Length; i++)
            {
                if (!words[i].Contains(c))
                {
                    res.Remove(c);
                    break;
                }
                else
                {
                    int index = words[i].IndexOf(c);
                    words[i] = words[i].Remove(index, 1);
                    // Console.WriteLine(words[i]);
                }

            }
        }
        return res;
    }
}