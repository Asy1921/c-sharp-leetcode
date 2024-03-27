namespace LeetCodeProblems;
public partial class LCProblems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public void ReorderList(ListNode head)
    {

        if (head == null || head.next == null)
            return;
        // printLinkedList(ReverseList(head));
        //Lets find the middle of the list
        ListNode middle = head;
        ListNode fast = head;
        while (fast != null)
        {
            middle = middle.next;
            fast = fast.next.next;
        }

        //Now we will make a second part of the list in reversed fashion
        ListNode part2 = ReverseList(middle.next);
        middle.next = null;
        ListNode part1 = head;

        while (part1 != null && part2 != null)
        {
            ListNode t1 = part1.next;
            ListNode t2 = part2.next;

            part1.next = part2;
            part2.next = t1;

            part1 = t1;
            part2 = t2;
        }
        printLinkedList(head);
    }
    public void printLinkedList(ListNode head)
    {
        while (head != null)
        {
            Console.WriteLine(head.val);
            head = head.next;
        }
    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;

        while (head != null)
        {
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        return prev;
    }
}
