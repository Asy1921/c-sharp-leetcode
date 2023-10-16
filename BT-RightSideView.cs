// 199.Binary Tree Right Side View
// Medium
// 11.2K
// 743
// Companies
// Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

namespace LeetCodeProblems;
public partial class LCProblems
{
    List<int> RView = new List<int>();
    public IList<int> RightSideView(TreeNode root)
    {
        dfs(root, 0);
        return RView;

    }
    public void dfs(TreeNode root, int i)
    {
        if (root == null)
        {
            return;
        }
        else if (i >= RView.Count)
        {
            RView.Add(root.val);
        }
        dfs(root.right, i + 1);
        dfs(root.left, i + 1);
    }
}