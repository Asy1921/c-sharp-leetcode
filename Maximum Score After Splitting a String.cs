//1422. Maximum Score After Splitting a String
//Easy
//1.2K
//52
//Companies
//Given a string s of zeros and ones, return the maximum score after splitting the string into two non-empty substrings (i.e. left substring and right substring).

//The score after splitting a string is the number of zeros in the left substring plus the number of ones in the right substring.
namespace LeetCodeProblems;
public partial class LCProblems{
  public int MaxScore(string s) {
        int zero=0;
        int one=1;
        int res=0;

        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='1')
            {
                one++;
            }
        }
        for(int i=0;i<s.Length-1;i++)
        {
            if(s[i]=='1')
            {
                one--;
                
            }
            else
            {
                zero++;
            }
            res=Math.Max(zero+one,res);
        }
        return res-1;
    }
}

 
