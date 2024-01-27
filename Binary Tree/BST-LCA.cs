// 235.Lowest Common Ancestor of a Binary Search Tree
// Medium
// 10.3K
// 288
// Companies
// Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”



namespace LeetCodeProblems;
public partial class LCProblems
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (true)
            {
                if (p.val > root.val && q.val > root.val)
                {
                    root = root.right;
                }
                else if (p.val < root.val && q.val < root.val)
                {
                    root = root.left;
                }
                else
                {
                    return root;
                }
            }
            return null;
        }
    }
}