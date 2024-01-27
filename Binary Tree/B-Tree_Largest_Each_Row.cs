//515. Find Largest Value in Each Tree Row
//Medium
//3.1K
//103
//Companies
//Given the root of a binary tree, return an array of the largest value in each row of the tree (0-indexed).

 
namespace LeetCodeProblems;
public partial class LCProblems
{
public List<int> res=new List<int>();
    public void FindLargest(TreeNode root,int level)
    {
        if(root==null)
        {
            return;
        }
        if(res.Count >= level + 1)
        {
            if(root.val>res[level])
            {
                res[level]=root.val;
            }

        }
        else
        {
            res.Add(root.val);
        }
        FindLargest(root.left,level+1);
        FindLargest(root.right,level+1);

    }
    public IList<int> LargestValues(TreeNode root) {
        FindLargest(root,0);
        return res;
        
    }
}
