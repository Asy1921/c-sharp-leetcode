// 229.Majority Element II
// Medium
// 8.7K
// 382
// Companies
// Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.



// Example 1:

// Input: nums = [3, 2, 3]
// Output: [3]
// Example 2:

// Input: nums = [1]
// Output: [1]
// Example 3:

// Input: nums = [1, 2]
// Output: [1,2]


namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<int> MajorityElement(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> res = new List<int>();
        int n = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
                if (map[nums[i]] > (n / 3))
                {
                    res.Add(nums[i]);
                    map[nums[i]] = Int32.MinValue;
                }
            }
            else
            {
                map.Add(nums[i], 1);
                if (map[nums[i]] > (n / 3))
                {
                    res.Add(nums[i]);
                    map[nums[i]] = Int32.MinValue;
                }
            }

        }
        return res;

    }
}