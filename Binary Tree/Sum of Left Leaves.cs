// 404. Sum of Left Leaves
// Solved
// Easy
// Topics
// Companies
// Given the root of a binary tree, return the sum of all left leaves.

// A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        int res = 0;

        if (root == null || root.left == null && root.right == null)
        {
            return res;
        }

        void calcSum(TreeNode cur)
        {
            if (cur == null)
            {
                return;
            }
            if (cur.left == null && cur.right == null)
            {
                res += cur.val;
                return;
            }
            calcSum(cur.left);
            if (cur.right != null && (cur.right.right != null || cur.right.left != null))
            {
                calcSum(cur.right);
            }
        }
        calcSum(root);
        return res;
    }
}