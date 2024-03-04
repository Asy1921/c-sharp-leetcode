// 948. Bag of Tokens
// Solved
// Medium
// Topics
// Companies
// You start with an initial power of power, an initial score of 0, and a bag of tokens given as an integer array tokens, where each tokens[i] donates the value of tokeni.

// Your goal is to maximize the total score by strategically playing these tokens. In one move, you can play an unplayed token in one of the two ways (but not both for the same token):

// Face-up: If your current power is at least tokens[i], you may play tokeni, losing tokens[i] power and gaining 1 score.
// Face-down: If your current score is at least 1, you may play tokeni, gaining tokens[i] power and losing 1 score.
// Return the maximum possible score you can achieve after playing any number of tokens
namespace LeetCodeProblems;

public partial class LCProblems
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        List<int> toks = tokens.ToList();
        int score = 0;
        if (tokens.Length == 0)
        {
            return score;
        }
        //Default move face up
        if (toks.Min() <= power)
        {
            score++;
            power -= toks.Min();
            toks.Remove(toks.Min());
        }

        while (toks.Count() > 0)
        {
            if (score > 0 && toks.Max() > power && toks.Count() > 2)
            {
                power += toks.Max();
                score--;
                toks.Remove(toks.Max());
            }
            else
            {
                if (toks.Min() <= power)
                {
                    score++;
                    power -= toks.Min();
                    toks.Remove(toks.Min());
                }
                else
                {
                    return score;
                }
            }

        }
        return score;
    }
}