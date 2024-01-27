
// 94. Binary Tree Inorder Traversal
// Easy
// 12.9K
// 705
// Companies
// Given the root of a binary tree, return the inorder traversal of its nodes' values.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();

        void Inorder(TreeNode cur)
        {
            if (cur == null)
            {
                return;
            }
            Inorder(cur.left);
            res.Add(cur.val);
            Inorder(cur.right);

        }
        Inorder(root);

        return res;
    }
}