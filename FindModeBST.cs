// 501.Find Mode in Binary Search Tree
// Easy
// 3.5K
// 722
// Companies
// Given the root of a binary search tree (BST) with duplicates, return all the mode(s) (i.e., the most frequently occurred element) in it.

// If the tree has more than one mode, return them in any order.

// Assume a BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than or equal to the node's key.
// The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
// Both the left and right subtrees must also be binary search trees.

namespace LeetCodeProblems;
public partial class LCProblems
{
    Dictionary<int, int> d = new Dictionary<int, int>();
    int maxOcc = 0;
    public int[] FindMode(TreeNode root)
    {
        List<int> res = new List<int>();
        CalcOcc(root);
        foreach (KeyValuePair<int, int> kvp in d)
        {
            if (kvp.Value == maxOcc)
            {
                res.Add(kvp.Key);
            }
        }
        return res.ToArray();
    }
    void CalcOcc(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        if (d.ContainsKey(root.val))
        {
            d[root.val]++;

        }
        else
        {
            d.Add(root.val, 1);
        }

        if (d[root.val] > maxOcc)
        {
            maxOcc = d[root.val];
        }

        CalcOcc(root.left);
        CalcOcc(root.right);
    }
}