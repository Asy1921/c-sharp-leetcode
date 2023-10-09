
namespace LeetCodeProblems;
public partial class LCProblems
{
    public string LongestCommonPrefix(string[] str)
    {
        if (str == null || str.Length == 0)
        {
            return "";
        }


        string min = str.Min();

        string res = min;

        foreach (string s in str)
        {
            while (!s.StartsWith(res))
            {
                res = res.Substring(0, res.Length - 1);

                if (res.Length == 0)
                {
                    return "";
                }
            }
        }

        return res;
    }
}