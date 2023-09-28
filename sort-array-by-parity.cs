// 905. Sort Array By Parity
// Easy
// 5K
// 138
// Companies
// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

// Return any array that satisfies this condition.

 

// Example 1:

// Input: nums = [3,1,2,4]
// Output: [2,4,3,1]
// Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
// Example 2:

// Input: nums = [0]
// Output: [0]
namespace LeetCodeProblems;
public partial class LCProblems {
    public int[] SortArrayByParity(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r) {
            while (l < r && (nums[l] % 2 == 0)) {
                // Move the left pointer to the right until an odd number is found
                l++;
            }

            while (l < r && (nums[r] % 2 != 0)) {
                // Move the right pointer to the left until an even number is found
                r--;
            }

            if (l < r) {
                // Swap the even and odd elements using bitwise XOR
                nums[l] ^= nums[r];
                nums[r] ^= nums[l];
                nums[l] ^= nums[r];

                // Move the pointers
                l++;
                r--;
            }
        }

        return nums;
    }
}
