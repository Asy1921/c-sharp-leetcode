
namespace LeetCodeProblems;
using static LeetCodeProblems.LCProblems;
public partial class LCProblems
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null || (head.next == null && n == 1))
        {
            return null;
        }

        ListNode prev = head;
        ListNode toBeRemoved = head;
        for (int i = 0; i <= n; i++)
        {
            prev = toBeRemoved;
            toBeRemoved = toBeRemoved.next;
        }
        prev.next = toBeRemoved.next;
        printLinkedList(head);
        return head;
    }
}