// 1448.Count Good Nodes in Binary Tree
// Medium
// 5.4K
// 140
// Companies
// Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.

// Return the number of good nodes in the binary tree.




namespace LeetCodeProblems;
public partial class LCProblems
{
    int goodNodes = 0;
    public int GoodNodes(TreeNode root)
    {
        CountGoodNodes(root, root.val);
        return goodNodes;

    }
    public void CountGoodNodes(TreeNode root, int greatestValue)
    {
        if (root == null)
        {
            return;
        }
        if (root.val >= greatestValue)
        {
            goodNodes++;
            greatestValue = root.val;
        }

        CountGoodNodes(root.right, greatestValue);
        CountGoodNodes(root.left, greatestValue);

    }
}