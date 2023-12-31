// 1266. Minimum Time Visiting All Points
// Easy
// 2K
// 204
// Companies
// On a 2D plane, there are n points with integer coordinates points[i] = [xi, yi]. Return the minimum time in seconds to visit all the points in the order given by points.

// You can move according to these rules:

// In 1 second, you can either:
// move vertically by one unit,
// move horizontally by one unit, or
// move diagonally sqrt(2) units (in other words, move one unit vertically then one unit horizontally in 1 second).
// You have to visit the points in the same order as they appear in the array.
// You are allowed to pass through points that appear later in the order, but these do not count as visits.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int res = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            res += Math.Max(Math.Abs(points[i][0] - points[i + 1][0]), Math.Abs(points[i][1] - points[i + 1][1]));
        }
        return res;
    }
}