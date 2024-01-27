// 437. Path Sum III
// Medium
// Topics
// Companies
// Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.

// The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int PathSum(TreeNode root, int targetSum)
    {

        if (root == null) return 0;

        return FindAllSums(root, targetSum)
            + PathSum(root.left, targetSum)
            + PathSum(root.right, targetSum);

        int FindAllSums(TreeNode curr, long sum)
        {
            int res = curr.val == sum ? 1 : 0;

            if (curr.left != null)
                res += FindAllSums(curr.left, sum - curr.val);

            if (curr.right != null)
                res += FindAllSums(curr.right, sum - curr.val);

            return res;
        }
    }
}