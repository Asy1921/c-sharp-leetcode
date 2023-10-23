namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsPowerOfFour(int x)
    {
        if (x == 0)
            return false;
        while (x % 4 == 0)
        {
            x = x / 4;
        }
        return x == 1;
    }
}