// 1716. Calculate Money in Leetcode Bank
// Easy
// 882
// 25
// Companies
// Hercy wants to save money for his first car. He puts money in the Leetcode bank every day.

// He starts by putting in $1 on Monday, the first day. Every day from Tuesday to Sunday, he will put in $1 more than the day before. On every subsequent Monday, he will put in $1 more than the previous Monday.
// Given n, return the total amount of money he will have in the Leetcode bank at the end of the nth day.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int TotalMoney(int n)
    {
        int res = 0;
        int m = n / 7;
        //week
        for (int i = 0; i < m; i++)
        {
            res += 28 + (i * 7);
        }
        //rem days
        for (int i = 1; i <= (n % 7); i++)
        {
            res += i + (n / 7);
        }
        return res;

    }
}
