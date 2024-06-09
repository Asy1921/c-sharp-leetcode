// 605. Can Place Flowers
// Solved
// Easy
// Topics
// Companies
// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.





namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool CanPlaceFlowers(int[] arr, int n)
    {
        int max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                continue;
            }
            if ((i == 0 || arr[i - 1] == 0) && (i == arr.Length - 1 || arr[i + 1] == 0))
            {
                arr[i] = 1;
                max++;
            }

        }
        return n <= max;
    }
}