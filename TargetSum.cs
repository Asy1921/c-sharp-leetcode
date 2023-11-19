// 494.Target Sum
// Medium
// 10.4K
// 335
// Companies
// You are given an integer array nums and an integer target.

// You want to build an expression out of nums by adding one of the symbols '+' and '-' before each integer in nums and then concatenate all the integers.

// For example, if nums = [2, 1], you can add a '+' before 2 and a '-' before 1 and concatenate them to build the expression "+2-1".
// Return the number of different expressions that you can build, which evaluates to target.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        int res = 0;

        void backtrack(int i, int sum, string s)
        {
            if (target == sum && i == nums.Length)
            {
                res++;
                Console.WriteLine(s);
                return;
            }
            if (i >= nums.Length)
            {
                return;
            }
            backtrack(i + 1, sum + nums[i], s + "+" + nums[i]);
            backtrack(i + 1, sum - nums[i], s + "-" + nums[i]);
        }


        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();
        //Backtrack with caching
        int bt(int i, int sum)
        {
            if (target == sum && i == nums.Length)
            {
                return 1;
            }
            if (i >= nums.Length)
            {
                return 0;
            }
            if (dp.ContainsKey((i, sum)))
            {
                return dp[(i, sum)];
            }
            else
            {
                dp.Add((i, sum), bt(i + 1, sum + nums[i]) + bt(i + 1, sum - nums[i]));
            }
            return dp[(i, sum)];
        }
        return bt(0, 0);
    }
}