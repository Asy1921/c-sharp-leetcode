// 452. Minimum Number of Arrows to Burst Balloons
// Solved
// Medium
// Topics
// Companies
// There are some spherical balloons taped onto a flat wall that represents the XY-plane. The balloons are represented as a 2D integer array points where points[i] = [xstart, xend] denotes a balloon whose horizontal diameter stretches between xstart and xend. You do not know the exact y-coordinates of the balloons.

// Arrows can be shot up directly vertically (in the positive y-direction) from different points along the x-axis. A balloon with xstart and xend is burst by an arrow shot at x if xstart <= x <= xend. There is no limit to the number of arrows that can be shot. A shot arrow keeps traveling up infinitely, bursting any balloons in its path.

// Given the array points, return the minimum number of arrows that must be shot to burst all balloons.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindMinArrowShots(int[][] points)
    {
        int res = 0;
        Array.Sort(points, new Comparer());
        int end = 0;
        for (int i = 0; i < points.Length; i++)
        {
            if (res == 0 || points[i][0] > end)
            {
                res++;
                end = points[i][1];
            }
        }
        return res;
    }
    private class Comparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b) => a[1].CompareTo(b[1]);

    }

}