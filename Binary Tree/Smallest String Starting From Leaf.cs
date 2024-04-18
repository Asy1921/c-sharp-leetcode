// 988. Smallest String Starting From Leaf
// Solved
// Medium
// Topics
// Companies
// You are given the root of a binary tree where each node has a value in the range [0, 25] representing the letters 'a' to 'z'.

// Return the lexicographically smallest string that starts at a leaf of this tree and ends at the root.

// As a reminder, any shorter prefix of a string is lexicographically smaller.

// For example, "ab" is lexicographically smaller than "aba".
// A leaf of a node is a node that has no children.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string SmallestFromLeaf(TreeNode root)
    {
        List<string> res = new();
        void TraverseAllLeafs(TreeNode curr, string str)
        {
            if (curr == null)
            {
                return;
            }
            str += (char)('a' + curr.val);
            if (curr.left == null && curr.right == null)
            {
                //Leaf Node
                res.Add(new string(str.Reverse().ToArray()));
                return;
            }
            TraverseAllLeafs(curr.left, str);
            TraverseAllLeafs(curr.right, str);

        }
        TraverseAllLeafs(root, "");
        return res.OrderBy(x => x).FirstOrDefault();
    }
}