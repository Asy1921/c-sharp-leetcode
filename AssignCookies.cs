// 455. Assign Cookies
// Easy
// 3.4K
// 311
// Companies
// Assume you are an awesome parent and want to give your children some cookies. But, you should give each child at most one cookie.

// Each child i has a greed factor g[i], which is the minimum size of a cookie that the child will be content with; and each cookie j has a size s[j]. If s[j] >= g[i], we can assign the cookie j to the child i, and the child i will be content. Your goal is to maximize the number of your content children and output the maximum number.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int cookies = 0;
        int j = 0;

        for (int i = 0; i < g.Length; i++)
        {
            if (j >= s.Length)
            {
                break;
            }
            while (j < s.Length)
            {
                if (g[i] <= s[j])
                {
                    cookies++;
                    j++;
                    break;
                }
                j++;

            }


        }
        return cookies;
    }
}