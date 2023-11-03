// 1441. Build an Array With Stack Operations
// Medium
// 722
// 353
// Companies
// You are given an integer array target and an integer n.

// You have an empty stack with the two following operations:

// "Push": pushes an integer to the top of the stack.
// "Pop": removes the integer on the top of the stack.
// You also have a stream of the integers in the range [1, n].

// Use the two stack operations to make the numbers in the stack (from the bottom to the top) equal to target. You should follow the following rules:

// If the stream of the integers is not empty, pick the next integer from the stream and push it to the top of the stack.
// If the stack is not empty, pop the integer at the top of the stack.
// If, at any moment, the elements in the stack (from the bottom to the top) are equal to target, do not read new integers from the stream and do not do more operations on the stack.
// Return the stack operations needed to build target following the mentioned rules. If there are multiple valid answers, return any of them.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<string> BuildArray(int[] target, int n)
    {
        List<string> res = new List<string>();
        List<int> s = new List<int>();
        int l = target.Length - 1;
        int cur = 0;

        for (int i = 1; i <= n; i++)
        {
            if (s.Count() == l + 1)
            {

                if (target[l] == s[l])
                { break; }

            }


            s.Add(i);
            res.Add("Push");
            cur++;
            if (target[cur - 1] != i)
            {
                if (s.Count > 0)
                {
                    s.RemoveAt(cur - 1);
                    res.Add("Pop");
                    cur--;

                }
            }



        }
        return res;
    }
}