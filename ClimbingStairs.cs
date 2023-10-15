// 70.Climbing Stairs
// Easy
// 20.2K
// 674
// Companies
// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int ClimbStairs(int n)
    {

        int oneStep = 1;
        int twoStep = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int temp = oneStep;
            oneStep = oneStep + twoStep;
            twoStep = temp;
        }

        return oneStep;
    }
}