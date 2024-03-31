// 66. Plus One
// Solved
// Easy
// Topics
// Companies
// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

// Increment the large integer by one and return the resulting array of digits.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        digits[n - 1]++;
        while (digits[n - 1] == 10)
        {

            digits[n - 1] = 0;
            n--;
            // if it's not the first digit
            if (n != 0)
            {
                digits[n - 1]++;
            }
            else
            {

                digits[0] = 1;
                digits = digits.Concat(new int[] { 0 }).ToArray();
                break;
            }
        }
        return digits;
    }
}