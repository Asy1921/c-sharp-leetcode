//  312. Burst Balloons
// Hard
// 8.6K
// 220
// Companies
// You are given n balloons, indexed from 0 to n - 1. Each balloon is painted with a number on it represented by an array nums. You are asked to burst all the balloons.

// If you burst the ith balloon, you will get nums[i - 1] * nums[i] * nums[i + 1] coins. If i - 1 or i + 1 goes out of bounds of the array, then treat it as if there is a balloon with a 1 painted on it.

// Return the maximum coins you can collect by bursting the balloons wisely.

 
 namespace LeetCodeProblems;
public partial class LCProblems
{   
 public int MaxCoins(int[] nums) {
           int n = nums.Length + 2;
        Dictionary <(int,int),int> dp=new Dictionary<(int,int),int>();
        int[] arr = new int[n];
        arr[0] = 1;
        arr[^1] = 1;
        for (int i = 1; i < n - 1; i++) 
        {arr[i] = nums[i - 1];}
        int dfs(int l, int r)
        {
            if(l>r)
            {
                return 0;
            }
            if(dp.ContainsKey((l,r)))
            {
                return dp[(l,r)];
            }
            dp.Add((l,r),0);
            for(int i=l;i<=r;i++)
            {
                int coins=arr[l-1]*arr[i]*arr[r+1];
                coins+=dfs(l,i-1)+dfs(i+1,r);
                dp[(l,r)]=Math.Max(dp[(l,r)],coins);
            }
            return dp[(l,r)];
        }
        return dfs(1,n-2);
    }
}