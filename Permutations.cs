//46. Permutations
//Medium
//18.1K
//292
//Companies
//Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

namespace LeetCodeProblems;
public partial class LCProblems
{
public List<IList<int>> resPerms=new List<IList<int>>();
    public void AddPerms(int[] arr,int l, int r)
    {
        if(l==r)
        {
            resPerms.Add(arr.ToList());
        }
        for(int i=l;i<=r;i++)
        {
            arr=swapItems(arr,l,i);
            AddPerms(arr,l+1,r);
            arr=swapItems(arr,l,i);
        }
    }

    public int[] swapItems(int[] arr,int a,int b)
    {
        int temp=arr[a];
        arr[a]=arr[b];
        arr[b]=temp;
        return arr;
    }
    public IList<IList<int>> Permute(int[] nums) {
        AddPerms(nums,0,nums.Length-1);
        return resPerms;
        
    }
}
