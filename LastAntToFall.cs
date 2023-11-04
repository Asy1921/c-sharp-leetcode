// 1503.Last Moment Before All Ants Fall Out of a Plank
// Medium
// 932
// 283
// Companies
// We have a wooden plank of the length n units. Some ants are walking on the plank, each ant moves with a speed of 1 unit per second. Some of the ants move to the left, the other move to the right.

// When two ants moving in two different directions meet at some point, they change their directions and continue moving again. Assume changing directions does not take any additional time.

// When an ant reaches one end of the plank at a time t, it falls out of the plank immediately.

// Given an integer n and two integer arrays left and right, the positions of the ants moving to the left and the right, return the moment when the last ant(s) fall out of the plank.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        int lmax = 0;
        if (left.Length > 0)
        {
            lmax = left.Max();
        }
        if (right.Length == 0)
        {
            return lmax;
        }
        int rmax = 0;
        foreach (int r in right)
        {

            rmax = Math.Max(rmax, n - r);
        }
        return Math.Max(lmax, rmax);
    }
}