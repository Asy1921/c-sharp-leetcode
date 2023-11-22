// 1424.Diagonal Traverse II
// Medium
// 1.9K
// 136
// Companies
// Given a 2D integer array nums, return all elements of nums in diagonal order as shown in the below images.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        Dictionary<int, List<int>> diagonalDict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 0; j < nums[i].Count; j++)
            {
                int diagonalIndex = i + j;

                if (!diagonalDict.ContainsKey(diagonalIndex))
                {
                    diagonalDict[diagonalIndex] = new List<int>();
                }

                diagonalDict[diagonalIndex].Add(nums[i][j]);
            }
        }

        List<int> result = new List<int>();

        foreach (var kvp in diagonalDict)
        {
            // Reverse the list before adding it to the result
            List<int> values = kvp.Value;
            values.Reverse(); // Reversing the list in place

            if (kvp.Key % 2 == 0)
            {
                result.AddRange(values);
            }
            else
            {
                result.AddRange(values);
            }
        }

        return result.ToArray();
    }
}