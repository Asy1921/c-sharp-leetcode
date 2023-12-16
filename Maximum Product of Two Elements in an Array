//1464. Maximum Product of Two Elements in an Array
//Easy
//2K
//202
//Companies
//Given the array of integers nums, you will choose two different indices i and j of that array. Return the maximum value of (nums[i]-1)*(nums[j]-1).

namespace LeetCodeProblems;
public partial class LCProblems{
public int MaxProduct(int[] nums) {
        int max=0;
        int smax=0;
       foreach(int a in nums)
       {
           if(a>max)
           {
               smax=max;
               max=a;
           }
           else
           {
               smax=Math.Max(smax,a);
           }
       }
        return (max-1)*(smax-1);
    }
}
 
