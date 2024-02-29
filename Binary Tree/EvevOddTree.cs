// 1609. Even Odd Tree
// Solved
// Medium
// Topics
// Companies
// Hint
// A binary tree is named Even-Odd if it meets the following conditions:

// The root of the binary tree is at level index 0, its children are at level index 1, their children are at level index 2, etc.
// For every even-indexed level, all nodes at the level have odd integer values in strictly increasing order (from left to right).
// For every odd-indexed level, all nodes at the level have even integer values in strictly decreasing order (from left to right).
// Given the root of a binary tree, return true if the binary tree is Even-Odd, otherwise return false.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsEvenOddTree(TreeNode root)
    {

        bool res = true;
        List<List<int>> TreeVal = new();
        void isEvenOddTree(TreeNode cur, int level)
        {
            if (cur == null)
            {
                return;
            }
            if (TreeVal.Count() < (level + 1))
            {
                TreeVal.Add(new List<int>());
            }

            if (level % 2 == 0)
            {
                //values should be odd and strictly increasing
                if (cur.val % 2 == 0 || (TreeVal[level].Count() > 0 && (TreeVal[level].Last() >= cur.val)))
                {
                    Console.WriteLine(cur.val);
                    res = false;
                    return;
                }

            }
            else
            {
                //values should be even and strictly decreasing
                if (cur.val % 2 != 0 || (TreeVal[level].Count() > 0 && (TreeVal[level].Last() <= cur.val)))
                {
                    Console.WriteLine(cur.val);
                    res = false;
                    return;
                }
            }
            TreeVal[level].Add(cur.val);
            isEvenOddTree(cur.left, level + 1);
            isEvenOddTree(cur.right, level + 1);


        }
        isEvenOddTree(root, 0);
        return res;
    }
}