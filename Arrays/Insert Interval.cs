// 57. Insert Interval
// Solved
// Medium
// Topics
// Companies
// You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

// Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

// Return intervals after the insertion.

// Note that you don't need to modify intervals in-place. You can make a new array and return it.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> res = new List<int[]>();

        foreach (int[] row in intervals)
        {
            if (row[0] > newInterval[1])
            {
                res.Add(newInterval);
                newInterval = row;
            }
            else if (row[1] < newInterval[0])
            {
                res.Add(row);
            }
            else
            {
                newInterval[0] = Math.Min(newInterval[0], row[0]);
                newInterval[1] = Math.Max(newInterval[1], row[1]);
            }
        }

        res.Add(newInterval);

        return res.ToArray();
    }
}