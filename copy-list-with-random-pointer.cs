// 138. Copy List with Random Pointer
// Medium
// 13K
// 1.3K
// Companies
// A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or null.

// Construct a deep copy of the list. The deep copy should consist of exactly n brand new nodes, where each new node has its value set to the value of its corresponding original node. Both the next and random pointer of the new nodes should point to new nodes in the copied list such that the pointers in the original list and copied list represent the same list state. None of the pointers in the new list should point to nodes in the original list.

// For example, if there are two nodes X and Y in the original list, where X.random --> Y, then for the corresponding two nodes x and y in the copied list, x.random --> y.

// Return the head of the copied linked list.

// The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of [val, random_index] where:

// val: an integer representing Node.val
// random_index: the index of the node (range from 0 to n-1) that the random pointer points to, or null if it does not point to any node.
// Your code will only be given the head of the original linked list.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public Node CopyRandomList()
    {   // Creating example test case
        Node head = new Node(4);
        Node head1 = new Node(3);
        Node head2 = new Node(2);
        head.next = head1;
        head.random = null;
        head1.next = head2;
        head1.random = head;
        head2.next = null;
        head2.random = head1;
        // Actual solution begins here
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node cur = head;
        if (head == null)
        {
            return null;
        }
        while (cur != null)
        {
            Node copy = new Node(cur.val);
            map.Add(cur, copy);
            cur = cur.next;
        }
        cur = head;
        while (cur != null)
        {
            Node copy = map[cur];
            if (cur.next == null)
            {
                copy.next = null;
            }
            else
            {
                copy.next = map[cur.next];
            }
            if (cur.random == null)
            {
                copy.random = null;
            }
            else
            {
                copy.random = map[cur.random];
            }
            cur = cur.next;
        }
        return map[head];
    }
}