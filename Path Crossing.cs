// 1496. Path Crossing
// Easy
// 1.1K
// 31
// Companies
// Given a string path, where path[i] = 'N', 'S', 'E' or 'W', each representing moving one unit north, south, east, or west, respectively. You start at the origin (0, 0) on a 2D plane and walk on the path specified by path.

// Return true if the path crosses itself at any point, that is, if at any time you are on a location you have previously visited. Return false otherwise.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public bool IsPathCrossing(string path)
    {
        HashSet<(int, int)> set = new HashSet<(int, int)>();

        set.Add((0, 0));
        int p = 0;
        int q = 0;
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'N')
            {
                q++;
            }
            else if (path[i] == 'S')
            {
                q--;
            }
            else if (path[i] == 'E')
            {
                p++;
            }
            else
            {
                p--;
            }
            if (set.Contains((p, q)))
            {
                return true;
            }
            else
            {
                set.Add((p, q));
            }
        }
        return false;
    }
}