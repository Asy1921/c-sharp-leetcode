// 1550.Three Consecutive Odds
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an integer array arr, return true if there are three consecutive odd numbers in the array. Otherwise, return false.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int count = 0;

        foreach (int n in arr)
        {
            if (n % 2 != 0)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count == 3)
            {
                return true;
            }
        }
        return false;
    }
}