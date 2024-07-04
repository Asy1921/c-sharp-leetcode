// 2181. Merge Nodes in Between Zeros
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given the head of a linked list, which contains a series of integers separated by 0's. The beginning and end of the linked list will have Node.val == 0.

// For every two consecutive 0's, merge all the nodes lying in between them into a single node whose value is the sum of all the merged nodes. The modified list should not contain any 0's.

// Return the head of the modified linked list
namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode MergeNodes(ListNode head)
    {
        ListNode cur = head;
        while (cur.next != null)
        {
            ListNode fast = cur.next;
            Console.WriteLine(cur.val);
            while (fast.val != 0 && fast.next != null)
            {
                cur.val += fast.val;
                fast = fast.next;
            }
            if (fast.next != null)
            // {   Console.WriteLine(cur.val);
            {
                cur.next = fast;
                cur = fast;
            }
            else
            {
                cur.next = null;
                break;
            }

        }
        return head;
    }
}