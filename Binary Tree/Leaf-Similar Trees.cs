// 872. Leaf-Similar Trees
// Easy
// 3.9K
// 99
// Companies
// Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.



// For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).

// Two binary trees are considered leaf-similar if their leaf value sequence is the same.

// Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

namespace LeetCodeProblems;
public partial class LCProblems
{

    string s1 = "";
    string s2 = "";
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {

        FindLeafs1(root1);
        FindLeafs2(root2);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        return s1 == s2;
    }
    public void FindLeafs1(TreeNode cur)
    {
        if (cur == null)
        {
            return;
        }
        if (cur.right == null && cur.left == null)
        {
            s1 += cur.val + "-";
            return;
        }
        FindLeafs1(cur.left);
        FindLeafs1(cur.right);
    }
    public void FindLeafs2(TreeNode cur)
    {
        if (cur == null)
        {
            return;
        }
        if (cur.right == null && cur.left == null)
        {
            s2 += cur.val + "-";
            return;
        }
        FindLeafs2(cur.left);
        FindLeafs2(cur.right);
    }

}