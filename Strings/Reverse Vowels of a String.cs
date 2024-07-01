// 345. Reverse Vowels of a String
// Solved
// Easy
// Topics
// Companies
// Given a string s, reverse only all the vowels in the string and return it.

// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string ReverseVowels(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        char[] res = s.ToCharArray();
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        while (l <= r)
        {
            if (vowels.Contains(res[l]))
            {
                //Find if there is a vowel on the right side
                while (l <= r)
                {
                    if (vowels.Contains(res[r]))
                    {
                        // Console.WriteLine(res[l]+"("+l+":"+res[r]+r);
                        char temp = res[l];
                        res[l] = res[r];
                        res[r] = temp;
                        r--;
                        break;
                    }
                    r--;
                }
            }

            l++;

        }
        return new string(res);
    }
}