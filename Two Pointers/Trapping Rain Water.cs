// 42.Trapping Rain Water
// Solved
// Hard
// Topics
// Companies
// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int Trap(int[] height)
    {
        if (height is null)
            return 0;
        int l = 0;
        int r = height.Length - 1;
        int area = 0;
        int lmax = height[l];
        int rmax = height[r];

        while (l < r)
        {
            if (lmax < rmax)
            {
                l++;
                lmax = Math.Max(lmax, height[l]);
                area += lmax - height[l];

            }
            else
            {
                r--;
                rmax = Math.Max(rmax, height[r]);
                area += rmax - height[r];
            }
        }
        return area;
    }
}