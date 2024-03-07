
// Code
// Testcase
// Test Result
// Test Result
// 876. Middle of the Linked List
// Solved
// Easy
// Topics
// Companies
// Given the head of a singly linked list, return the middle node of the linked list.

// If there are two middle nodes, return the second middle node.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
}
