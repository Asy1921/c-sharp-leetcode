// 111. Minimum Depth of Binary Tree
// Solved
// Easy
// Topics
// Companies
// Given a binary tree, find its minimum depth.

// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

// Note: A leaf is a node with no children.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        int res = Int32.MaxValue;

        void FindMinDepth(TreeNode cur, int depth)
        {
            if (cur == null)
                return;
            if (cur.left == null && cur.right == null)
            {
                res = Math.Min(res, depth);
                return;
            }
            FindMinDepth(cur.left, depth + 1);
            FindMinDepth(cur.right, depth + 1);
        }
        FindMinDepth(root, 1);
        return res;
    }
}