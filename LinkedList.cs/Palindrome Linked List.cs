// 234.Palindrome Linked List
// Easy
// Topics
// Companies
// Given the head of a singly linked list, return true if it is a 
// palindrome
//  or false otherwise.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head; ListNode fast = head; ListNode prev = null;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            ListNode next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }
        if (fast != null)
        {
            slow = slow.next;
        }

        while (slow != null || prev != null)
        {
            if (slow.val != prev.val)
            { return false; }
            slow = slow.next;
            prev = prev.next;

        }
        return true;
    }
}