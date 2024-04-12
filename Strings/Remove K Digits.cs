// 402. Remove K Digits
// Solved
// Medium
// Topics
// Companies
// Given string num representing a non-negative integer num, and an integer k, return the smallest possible integer after removing k digits from num.

using System.Text;

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string RemoveKdigits(string num, int k)
    {
        if (k >= num.Length) return "0"; // If we can remove all digits, return "0"

        var stack = new Stack<char>();

        // Iterate over each digit
        foreach (char digit in num)
        {
            // Remove digits from the stack until either the stack is empty or we've removed k digits
            while (k > 0 && stack.Count > 0 && stack.Peek() > digit)
            {
                stack.Pop();
                k--;
            }
            stack.Push(digit);
        }

        // If there are still remaining digits to be removed, remove them from the end
        while (k > 0)
        {
            stack.Pop();
            k--;
        }

        // Build the result string
        var result = new StringBuilder();
        while (stack.Count > 0)
        {
            result.Insert(0, stack.Pop()); // Insert at the beginning to maintain the order
        }

        // Remove leading zeros
        while (result.Length > 1 && result[0] == '0')
        {
            result.Remove(0, 1);
        }

        return result.ToString();
    }
}
