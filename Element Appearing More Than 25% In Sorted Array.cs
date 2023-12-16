//1287. Element Appearing More Than 25% In Sorted Array
//Easy
//1.3K
//59
//Companies
//Given an integer array sorted in non-decreasing order, there is exactly one integer in the array that occurs more than 25% of the time, return that integer.

namespace LeetCodeProblems;
public partial class LCProblems{
public int FindSpecialInteger(int[] arr) {
        int len=arr.Length;
        int count=0;
        for(int i=0;i<len;i++)
        {
            if(i-1>=0&& arr[i]!=arr[i-1])
            {
                count=1;
                
            }
            else{
                count++;
            }
            if(count>len/4)
            {
                return arr[i];
            }
        }
        return arr[0];
    }

}

 
