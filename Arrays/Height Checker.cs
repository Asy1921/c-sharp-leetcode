// 1051. Height Checker
// Solved
// Easy
// Topics
// Companies
// Hint
// A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.

// You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).

// Return the number of indices where heights[i] != expected[i].

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int HeightChecker(int[] heights)
    {
        int[] exp = new int[heights.Length];
        Array.Copy(heights, exp, heights.Length);
        Array.Sort(heights);
        int res = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != exp[i])
            {
                res++;
            }
        }
        return res;
    }
}