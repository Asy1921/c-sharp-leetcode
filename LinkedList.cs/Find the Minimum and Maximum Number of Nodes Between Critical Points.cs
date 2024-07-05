// 2058. Find the Minimum and Maximum Number of Nodes Between Critical Points
// Solved
// Medium
// Topics
// Companies
// Hint
// A critical point in a linked list is defined as either a local maxima or a local minima.

// A node is a local maxima if the current node has a value strictly greater than the previous node and the next node.

// A node is a local minima if the current node has a value strictly smaller than the previous node and the next node.

// Note that a node can only be a local maxima/minima if there exists both a previous node and a next node.

// Given a linked list head, return an array of length 2 containing [minDistance, maxDistance] where minDistance is the minimum distance between any two distinct critical points and maxDistance is the maximum distance between any two distinct critical points. If there are fewer than two critical points, return [-1, -1].



namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] NodesBetweenCriticalPoints(ListNode head)
    {
        ListNode prev = head;
        ListNode cur = head.next;
        List<bool> countMaxi = new() { false };

        while (cur.next != null)
        {
            if ((cur.val > prev.val && cur.val > cur.next.val) || (cur.val < prev.val && cur.val < cur.next.val))
            {
                countMaxi.Add(true);
                Console.WriteLine(cur.val);

            }
            else
            {
                countMaxi.Add(false);
            }
            prev = cur;
            cur = cur.next;

        }
        int minDist = int.MaxValue;
        int prevV = -1;
        int first = int.MaxValue;
        int last = -1;
        for (int i = 0; i < countMaxi.Count(); i++)
        {
            if (countMaxi[i] == true)
            {
                if (first == int.MaxValue)
                {
                    first = i;

                }
                if (prevV != -1)
                {
                    minDist = Math.Min(minDist, i - prevV);

                    last = i;

                }
                prevV = i;
            }
        }
        if (minDist == int.MaxValue)
        {
            minDist = -1;
        }
        if (last - first > 0)
            return [minDist, last - first];
        else
            return [minDist, -1];
    }
}