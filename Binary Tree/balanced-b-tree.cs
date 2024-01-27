// 110.Balanced Binary Tree
// Easy
// 9.9K
// 576
// Companies
// Given a binary tree, determine if it is 
// height-balanced

namespace LeetCodeProblems;
public partial class LCProblems
{
    bool bres = true;
    public bool IsBalanced(TreeNode root)
    {
        bdfs(root);
        return bres;
    }
    public int bdfs(TreeNode root)
    {
        if (root == null)
        {
            return -1;
        }
        int l = bdfs(root.left);
        int r = bdfs(root.right);
        bres = bres && (Math.Abs(r - l) <= 1);

        return Math.Max(l, r) + 1;
    }
}