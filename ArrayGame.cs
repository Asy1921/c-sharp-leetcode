// 1535.Find the Winner of an Array Game
// Medium
// 997
// 47
// Companies
// Given an integer array arr of distinct integers and an integer k.

// A game will be played between the first two elements of the array (i.e. arr[0] and arr[1]). In each round of the game, we compare arr[0] with arr[1], the larger integer wins and remains at position 0, and the smaller integer moves to the end of the array. The game ends when an integer wins k consecutive rounds.

// Return the integer which will win the game.

// It is guaranteed that there will be a winner of the game.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int GetWinner(int[] arr, int k)
    {
        int wins = 1;
        if (k >= arr.Length)
        {
            return arr.Max();
        }
        int curmax = Math.Max(arr[0], arr[1]);
        for (int i = 2; i < arr.Length; i++)
        {
            if (wins == k)
            {
                return curmax;
            }
            int max = Math.Max(arr[i], curmax);
            if (curmax == max)
            {
                wins++;
            }
            else
            {
                curmax = max;
                wins = 1;
            }

        }
        return curmax;


    }
}