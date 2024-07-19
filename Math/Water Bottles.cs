// 1518. Water Bottles
// Solved
// Easy
// Topics
// Companies
// Hint
// There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.

// The operation of drinking a full water bottle turns it into an empty bottle.

// Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int empty = numBottles;
        int res = numBottles;

        while (empty >= numExchange)
        {
            int exchanged = empty / numExchange;
            empty = empty % numExchange;
            res += exchanged;
            empty += exchanged;
        }
        return res;
    }
}