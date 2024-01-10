// 2385. Amount of Time for Binary Tree to Be Infected
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given the root of a binary tree with unique values, and an integer start. At minute 0, an infection starts from the node with value start.

// Each minute, a node becomes infected if:

// The node is currently uninfected.
// The node is adjacent to an infected node.
// Return the number of minutes needed for the entire tree to be infected.



namespace LeetCodeProblems;
public partial class LCProblems
{
    private int MaxDist = int.MinValue;

    public int AmountOfTime(TreeNode root, int start)
    {
        CalcInfecTime(root, start, true);
        return MaxDist;
    }

    private int CalcInfecTime(TreeNode root, int start, bool StartNodeFound)
    {
        if (root == null) return 0;

        if (root.val == start && StartNodeFound)
        {
            MaxDist = Math.Max(MaxDist, CalcInfecTime(root, start, false) - 1);
            return -1;
        }

        int lh = CalcInfecTime(root.left, start, StartNodeFound);
        int rh = CalcInfecTime(root.right, start, StartNodeFound);

        if (lh < 0 || rh < 0)
        {
            MaxDist = Math.Max(MaxDist, Math.Abs(lh) + Math.Abs(rh));
            return Math.Min(lh, rh) - 1;
        }

        return Math.Max(lh, rh) + 1;
    }
}