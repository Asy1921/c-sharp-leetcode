// 1669.Merge In Between Linked Lists
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given two linked lists: list1 and list2 of sizes n and m respectively.

// Remove list1's nodes from the ath node to the bth node, and put list2 in their place.

// The blue edges and nodes in the following figure indicate the result:


// Build the result list and return its head.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode cur = list1;
        ListNode cur2 = list2;
        ListNode ptra = null;
        ListNode ptrb = null;
        int i = 0;
        while (cur != null)
        {
            if (i + 1 == a)
            {
                ptra = cur;
            }
            if (i - 1 == b)
            {
                ptrb = cur;
                break;
            }
            cur = cur.next;
            i++;
        }
        ptra.next = list2;
        while (list2.next != null)
        {
            list2 = list2.next;
        }
        list2.next = ptrb;

        return list1;
    }
}