// 374. Guess Number Higher or Lower
// Easy
// Topics
// Companies
// We are playing the Guess Game. The game is as follows:

// I pick a number from 1 to n. You have to guess which number I picked.

// Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

// You call a pre-defined API int guess(int num), which returns three possible results:

// -1: Your guess is higher than the number I picked (i.e. num > pick).
// 1: Your guess is lower than the number I picked (i.e. num < pick).
// 0: your guess is equal to the number I picked (i.e. num == pick).
// Return the number that I picked.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int guess(int num)
    {
        if (num == 6)
        {
            return 0;
        }
        else if (num < 6)
        {
            return -1;
        }
        return 1;
    }
    public int GuessNumber(int n)
    {
        int l = 1;
        int r = n;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            int check = guess(mid);
            if (check == 0)
            {
                return mid;
            }
            else if (check == -1)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }

        }
        return -1;
    }
}