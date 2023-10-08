// 543.Diameter of Binary Tree
// Easy
// 12.6K
// 791
// Companies
// Given the root of a binary tree, return the length of the diameter of the tree.

// The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

// The length of a path between two nodes is represented by the number of edges between them.

namespace LeetCodeProblems;
public partial class LCProblems
{
    int res = -1;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        dfs(root);
        return res;
    }

    private int dfs(TreeNode curr)
    {
        if (curr == null)
        {
            return -1;
        }
        int l = 1 + dfs(curr.left);
        int r = 1 + dfs(curr.right);
        res = Math.Max(res, (l + r));
        return Math.Max(l, r);
    }
}