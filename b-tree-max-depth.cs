// 104.Maximum Depth of Binary Tree
// Easy
// 11.9K
// 194
// Companies
// Given the root of a binary tree, return its maximum depth.

// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));

    }
}