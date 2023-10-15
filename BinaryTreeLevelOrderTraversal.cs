// 102.Binary Tree Level Order Traversal
// Medium
// 14.4K
// 288
// Companies
// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> res = new List<IList<int>>();

        Check(root, res, 0);
        return res;
    }
    private void Check(TreeNode root, List<IList<int>> res, int index)
    {
        if (root == null)
            return;
        if (res.Count <= index)
            res.Add(new List<int>());
        res[index].Add(root.val);
        index++;
        Check(root.left, res, index);
        Check(root.right, res, index);
    }
}