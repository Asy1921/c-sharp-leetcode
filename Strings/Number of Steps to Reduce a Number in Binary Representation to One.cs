// 1404. Number of Steps to Reduce a Number in Binary Representation to One
// Solved
// Medium
// Topics
// Companies
// Hint
// Given the binary representation of an integer as a string s, return the number of steps to reduce it to 1 under the following rules:

// If the current number is even, you have to divide it by 2.

// If the current number is odd, you have to add 1 to it.

// It is guaranteed that you can always reach one for all test cases.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumSteps(string s)
    {
        int num = 0;
        int index = s.Length - 1;
        while (s[index] == '0')
        {
            num++;
            index--;
        }

        int ones = 0;
        while (index >= 0)
        {
            if (s[index] == '0')
            {
                num += ones + 1;
                ones = 1;
            }
            else
            {
                ones++;
            }
            index--;
        }

        return num + ((ones > 1) ? ones + 1 : 0);
    }
}