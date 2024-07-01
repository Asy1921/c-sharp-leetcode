// 2285. Maximum Total Importance of Roads
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given an integer n denoting the number of cities in a country. The cities are numbered from 0 to n - 1.

// You are also given a 2D integer array roads where roads[i] = [ai, bi] denotes that there exists a bidirectional road connecting cities ai and bi.

// You need to assign each city with an integer value from 1 to n, where each value can only be used once. The importance of a road is then defined as the sum of the values of the two cities it connects.

// Return the maximum total importance of all roads possible after assigning the values optimally.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public long MaximumImportance(int n, int[][] roads)
    {
        long res = 0;
        long[] nodes = new long[n];
        foreach (var road in roads)
        {
            nodes[road[0]]++;
            nodes[road[1]]++;
        }
        Array.Sort(nodes, (a, b) => b.CompareTo(a));
        for (int i = 0; i < n; i++)
            res += (nodes[i] * (n - i));
        return res;
    }
}