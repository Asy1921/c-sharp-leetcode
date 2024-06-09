// 2487.Remove Nodes From Linked List
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given the head of a linked list.

// Remove every node which has a node with a greater value anywhere to the right side of it.

// Return the head of the modified linked list.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode RemoveNodes(ListNode head)
    {


        ListNode curr = ReverseList(head);
        Stack<int> valid = new();
        valid.Push(curr.val);
        curr = curr.next;
        while (curr != null)
        {

            if (curr.val >= valid.Peek())
            {
                valid.Push(curr.val);

            }
            curr = curr.next;

        }
        ListNode res = new ListNode()
        {
            val = valid.Pop(),
            next = null

        };
        curr = res;
        while (valid.Count > 0)
        {
            curr.next = new ListNode()
            {
                val = valid.Pop(),
                next = null

            };
            curr = curr.next;
        }
        return res;
    }


}