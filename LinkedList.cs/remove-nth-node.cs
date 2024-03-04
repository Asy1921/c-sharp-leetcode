
// 19.Remove Nth Node From End of List
// Medium
// 17.3K
// 711
// Companies
// Given the head of a linked list, remove the nth node from the end of the list and return its head.



// Example 1:


// Input: head = [1, 2, 3, 4, 5], n = 2
// Output: [1,2,3,5]
// Example 2:

// Input: head = [1], n = 1
// Output: []
// Example 3:

// Input: head = [1, 2], n = 1
// Output: [1]


// Constraints:

// The number of nodes in the list is sz.
// 1 <= sz <= 30
// 0 <= Node.val <= 100
// 1 <= n <= sz
using static LeetCodeProblems.LCProblems;
namespace LeetCodeProblems;

public partial class LCProblems
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null || (head.next == null && n == 1))
        {
            return null;
        }
        ListNode reversed = ReverseList(head);
        if (n == 1)
        {
            reversed = reversed.next;
            ReverseList(reversed);
            return head;
        }
        ListNode prev = reversed;
        ListNode toBeRemoved = reversed;

        for (int i = 0; i < n - 1; i++)
        {
            prev = toBeRemoved;
            toBeRemoved = toBeRemoved.next;
        }
        prev.next = toBeRemoved.next;

        return ReverseList(reversed);
    }

}