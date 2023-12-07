// 189. Rotate Array
// Medium

// The Rotate method rotates an array of integers, nums, to the right by k positions. 
// It adjusts k to avoid unnecessary rotations, stores the last k elements, 
// shifts the array elements to create space, and finally places the stored elements at the beginning to achieve the rotation.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public void Rotate(int[] nums, int k) {
        // Adjust k to avoid unnecessary rotations
        while (nums.Length < k) {
            k -= nums.Length;
        }

        // Create an array to store the rotated part
        int[] storedPart = new int[k];

        // Store the last 'k' elements in the array
        for (int i = nums.Length - k; i < nums.Length; i++) {
            storedPart[i - nums.Length + k] = nums[i];
        }

        // Shift the elements to the right to make space for rotated part
        for (int j = nums.Length - 1; j >= k; j--) {
            nums[j] = nums[j - k];
        }

        // Place the stored rotated part at the beginning
        for (int a = 0; a < k; a++) {
            nums[a] = storedPart[a];
        }
    }

}