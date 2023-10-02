

// 2038.Remove Colored Pieces if Both Neighbors are the Same Color
// Medium
// 1K
// 84
// Companies
// There are n pieces arranged in a line, and each piece is colored either by 'A' or by 'B'. You are given a string colors of length n where colors[i] is the color of the ith piece.

// Alice and Bob are playing a game where they take alternating turns removing pieces from the line. In this game, Alice moves first.

// Alice is only allowed to remove a piece colored 'A' if both its neighbors are also colored 'A'. She is not allowed to remove pieces that are colored 'B'.
// Bob is only allowed to remove a piece colored 'B' if both its neighbors are also colored 'B'. He is not allowed to remove pieces that are colored 'A'.
// Alice and Bob cannot remove pieces from the edge of the line.
// If a player cannot make a move on their turn, that player loses and the other player wins.
// Assuming Alice and Bob play optimally, return true if Alice wins, or return false if Bob wins.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool WinnerOfGame(string s)
    {
        int a = 0;
        int b = 0;
        for (int i = 1; i < s.Length - 1; i++)
        {
            if (s[i] == s[i - 1] & s[i] == s[i + 1])
            {
                if (s[i] == 'A')
                {
                    a++;
                }
                else if (s[i] == 'B')
                {
                    b++;
                }
            }
        }
        return a > b ? true : false;
    }
}