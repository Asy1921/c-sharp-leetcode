// 623. Add One Row to Tree
// Solved
// Medium
// Topics
// Companies
// Given the root of a binary tree and two integers val and depth, add a row of nodes with value val at the given depth depth.

// Note that the root node is at depth 1.

// The adding rule is:

// Given the integer depth, for each not null tree node cur at the depth depth - 1, create two tree nodes with value val as cur's left subtree root and right subtree root.
// cur's original left subtree should be the left subtree of the new left subtree root.
// cur's original right subtree should be the right subtree of the new right subtree root.
// If depth == 1 that means there is no depth depth - 1 at all, then create a tree node with value val as the new root of the whole original tree, and the original tree is the new root's left subtree.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth is 0 or 1)
        {
            return new TreeNode(val)
            {
                left = depth == 1 ? root : null,
                right = depth == 0 ? root : null
            };
        }

        if (root != null && depth >= 2)
        {
            root.left = AddOneRow(root.left, val, depth > 2 ? depth - 1 : 1);
            root.right = AddOneRow(root.right, val, depth > 2 ? depth - 1 : 0);
        }

        return root;
    }
}