// 129.Sum Root to Leaf Numbers
// Solved
// Medium
// Topics
// Companies
// You are given the root of a binary tree containing digits from 0 to 9 only.

// Each root-to-leaf path in the tree represents a number.

// For example, the root-to-leaf path 1 -> 2 -> 3 represents the number 123.
// Return the total sum of all root-to-leaf numbers. Test cases are generated so that the answer will fit in a 32-bit integer.

// A leaf node is a node with no children.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int SumNumbers(TreeNode root)
    {
        int res = 0;
        void CalcLeafSum(TreeNode cur, string prev)
        {
            if (cur == null)
            {
                return;
            }
            prev += cur.val.ToString();
            if (cur.left == null && cur.right == null)
            {
                res += Int32.Parse(prev);
                return;
            }
            CalcLeafSum(cur.left, prev);
            CalcLeafSum(cur.right, prev);

        }
        CalcLeafSum(root, "0");
        return res;

    }
}