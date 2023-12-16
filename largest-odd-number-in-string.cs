//1903. Largest Odd Number in String
//Easy
//1.6K
//90
//Companies
//You are given a string num, representing a large integer. Return the largest-valued odd integer (as a string) that is a non-empty substring of num, or an empty string "" if no odd integer exists.

A substring is a contiguous sequence of characters within a string.
namespace LeetCodeProblems;

public partial class LCProblems{
 public string LargestOddNumber(string num) {
        for(int i=num.Length-1;i>=0;i--)
        {
            if(num[i]%2!=0)
            {
                return num.Substring(0,i+1);
            }
        }
        return "";
    }
}
