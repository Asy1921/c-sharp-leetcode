// 230.Kth Smallest Element in a BST
// Medium
// 10.7K
// 201
// Companies
// Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int KthSmallest(TreeNode root, int k)
    {
        TreeNode cur = root;
        int n = 0;
        Stack<TreeNode> s = new Stack<TreeNode>();
        while (cur != null || s.Count > 0)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }
            cur = s.Pop();
            n++;
            if (n == k)
            {
                return cur.val;
            }
            cur = cur.right;
        }
        return 0;

    }
}