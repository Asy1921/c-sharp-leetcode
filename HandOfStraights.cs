
// 846. Hand of Straights
// Medium
// 2.4K
// 162
// Companies
// Alice has some number of cards and she wants to rearrange the cards into groups so that each group is of size groupSize, and consists of groupSize consecutive cards.

// Given an integer array hand where hand[i] is the value written on the ith card and an integer groupSize, return true if she can rearrange the cards, or false otherwise.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        var dict = new Dictionary<int, int>();
        foreach (var item in hand)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict.Add(item, 1);
            }
        }
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (var item in dict)
        {
            pq.Enqueue(item.Key, item.Key);
        }
        while (pq.Count > 0)
        {
            int start = pq.Peek();
            for (int i = 0; i < groupSize; i++)
            {
                if (!dict.ContainsKey(start + i))
                {
                    return false;
                }
                dict[start + i]--;
                if (dict[start + i] == 0)
                {
                    if (start + i != pq.Peek())
                    {
                        return false;
                    }
                    else
                    {
                        pq.Dequeue();
                    }
                }
            }
        }
        return true;
    }
}