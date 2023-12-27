// 1578. Minimum Time to Make Rope Colorful
// Medium
// 3.4K
// 106
// Companies
// Alice has n balloons arranged on a rope. You are given a 0-indexed string colors where colors[i] is the color of the ith balloon.

// Alice wants the rope to be colorful. She does not want two consecutive balloons to be of the same color, so she asks Bob for help. Bob can remove some balloons from the rope to make it colorful. You are given a 0-indexed integer array neededTime where neededTime[i] is the time (in seconds) that Bob needs to remove the ith balloon from the rope.

// Return the minimum time Bob needs to make the rope colorful.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MinCost(string colors, int[] neededTime)
    {
        int last = 0;

        int time = 0;
        for (int i = 1; i < colors.Length; i++)
        {
            if (colors[i] == colors[last])
            {
                //Same color remove min time
                if (neededTime[i] > neededTime[last])
                {
                    time += neededTime[last];
                    last = i;
                }
                else
                {
                    time += neededTime[i];
                }
            }
            else
            {
                last = i;
            }
        }
        return time;
    }
}