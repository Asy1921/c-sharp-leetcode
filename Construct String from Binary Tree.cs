//  606. Construct String from Binary Tree
// Easy
// 3K
// 3.5K
// Companies
// Given the root of a binary tree, construct a string consisting of parenthesis and integers from a binary tree with the preorder traversal way, and return it.

// Omit all the empty parenthesis pairs that do not affect the one-to-one mapping relationship between the string and the original binary tree.

 
 namespace LeetCodeProblems;
public partial class LCProblems
{public string Tree2str(TreeNode root) {
        if (root == null) {
            return "";
        }

        StringBuilder res = new StringBuilder();

        void preorder(TreeNode cur) {
            if (cur == null) {
                return;
            }

            res.Append(cur.val);

            if (cur.left != null || cur.right != null) {
                res.Append("(");
                preorder(cur.left);
                res.Append(")");

                if (cur.right != null) {
                    res.Append("(");
                    preorder(cur.right);
                    res.Append(")");
                }
            }
        }

        preorder(root);

        return res.ToString();
    }
}