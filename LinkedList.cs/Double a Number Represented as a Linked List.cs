// 2816.Double a Number Represented as a Linked List
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given the head of a non-empty linked list representing a non-negative integer without leading zeroes.

// Return the head of the linked list after doubling it.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode DoubleIt(ListNode head)
    {
        int carryOver = 0;
        ListNode cur = head;
        Stack<int> store = new();
        while (cur != null)
        {
            store.Push(cur.val);
            cur = cur.next;
        }
        ListNode r = null;
        int carry = 0;
        while (store.Count > 0)
        {
            int p = store.Pop() * 2 + carry;
            Console.WriteLine(p + "," + carry);
            if (p > 9)
                carry = 1;
            else
                carry = 0;
            ListNode n = new ListNode()
            {
                val = p % 10,
                next = r
            };
            r = n;
        }
        if (carry > 0)
        {
            ListNode n = new ListNode()
            {
                val = carry,
                next = r
            };
            r = n;
        }
        return r;
    }
}