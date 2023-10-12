
// 572.Subtree of Another Tree
// Easy
// 7.8K
// 452
// Companies
// Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

// A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
        {
            return root == subRoot;
        }
        if (root.val == subRoot?.val && IsSameTree(root, subRoot))
        { return true; }

        return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
    }
}