// 24. Swap Nodes in Pairs
// Solved
// Medium
// Topics
// Companies
// Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode SwapPairs(ListNode head)
    {

        ListNode ln;
        ln = head;

        while (ln != null && ln.next != null)
        {
            int temp = ln.next.val;
            ln.next.val = ln.val;
            ln.val = temp;
            ln = ln.next.next;
        }
        return head;
    }
}