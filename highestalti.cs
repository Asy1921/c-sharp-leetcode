
// 1732. Find the Highest Altitude
// Easy
// 2.7K
// 255
// Companies
// There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

// You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int LargestAltitude(int[] gain)
    {
        int max = 0;
        int curh = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            curh += gain[i];
            max = Math.Max(curh, max);
        }
        return max;
    }
}