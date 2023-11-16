// 1980.Find Unique Binary String
// Medium
// 1.6K
// 59
// Companies
// Given an array of strings nums containing n unique binary strings each of length n, return a binary string of length n that does not appear in nums. If there are multiple answers, you may return any of them.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public List<string> binaryStrings = new List<string>();
    public string FindDifferentBinaryString(string[] nums)
    {
        GenCombinations(nums[0].Length, "");
        foreach (string s in binaryStrings)
        {
            if (!nums.Contains(s))
            {
                return s;
            }
        }
        return "";
    }
    public void GenCombinations(int n, string str)
    {
        if (str.Length == n)
        {
            binaryStrings.Add(str);
            return;
        }
        GenCombinations(n, str + "1");
        GenCombinations(n, str + "0");

    }
}