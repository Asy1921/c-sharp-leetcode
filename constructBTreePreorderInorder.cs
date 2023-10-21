// 105. Construct Binary Tree from Preorder and Inorder Traversal
// Medium
// 14.1K
// 430
// Companies
// Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        TreeNode root = BuildTreeNodes(preorder, inorder);
        return root;

    }
    public TreeNode BuildTreeNodes(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 || inorder.Length == 0)
        {
            return null;
        }
        TreeNode root = new TreeNode(preorder[0]);
        int mid = Array.IndexOf(inorder, root.val);
        root.left = BuildTreeNodes(preorder[1..(mid + 1)], inorder[0..mid]);
        root.right = BuildTreeNodes(preorder[(mid + 1)..(preorder.Length)], inorder[(mid + 1)..(inorder.Length)]);
        return root;

    }
}