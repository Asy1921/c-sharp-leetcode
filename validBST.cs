// 98.Validate Binary Search Tree
// Medium
// 15.9K
// 1.3K
// Companies
// Given the root of a binary tree, determine if it is a valid binary search tree (BST).

// A valid BST is defined as follows:

// The left 
// subtree
//  of a node contains only nodes with keys less than the node's key.
// The right subtree of a node contains only nodes with keys greater than the node's key.
// Both the left and right subtrees must also be binary search trees.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, null, null);
    }

    public bool IsValid(TreeNode root, int? min, int? max)
    {
        if (root == null)
        {
            return true;
        }

        var current = root.val;

        if (current <= min || current >= max)
        {
            return false;
        }

        return IsValid(root.left, min, current) && IsValid(root.right, current, max);
    }
}