// 131. Palindrome Partitioning
// Medium
// 11.9K
// 383
// Companies
// Given a string s, partition s such that every 
// substring
//  of the partition is a 
// palindrome
// . Return all possible palindrome partitioning of s.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<string>> Partition(string s)
    {
        List<IList<string>> res = new List<IList<string>>();
        List<string> cur = new List<string>();
        bool PalindromeCheck(string str)
        {
            int l = 0;
            int r = str.Length - 1;
            while (l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }

        void backtrack(int i)
        {
            if (i >= s.Length)
            {
                res.Add(new List<string>(cur));
            }
            for (int j = i; j < s.Length; j++)
            {
                if (PalindromeCheck(s.Substring(i, j - i + 1)))
                {
                    cur.Add(s.Substring(i, j - i + 1));
                    backtrack(j + 1);
                    cur.RemoveAt(cur.Count - 1);
                }
            }
        }
        backtrack(0);
        return res;

    }
}