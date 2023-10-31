// 746. Min Cost Climbing Stairs
// Easy
// 10.8K
// 1.6K
// Companies
// You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

// You can either start from the step with index 0, or the step with index 1.

// Return the minimum cost to reach the top of the floor.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MinCostClimbingStairs(int[] cost)
    {
        cost.Append(0);
        for (int i = cost.Length - 3; i >= 0; i--)
        {
            cost[i] += Math.Min(cost[i + 2], cost[i + 1]);
        }

        return Math.Min(cost[0], cost[1]);
    }
}