// 100.Same Tree
// Easy
// 10.5K
// 202
// Companies
// Given the roots of two binary trees p and q, write a function to check if they are the same or not.

// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null || q == null)
            return p == q;

        return
            p.val == q.val &&
            IsSameTree(p.left, q.left) &&
            IsSameTree(p.right, q.right);
    }
}