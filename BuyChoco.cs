//2706. Buy Two Chocolates
//Easy
//568
//34
//Companies
//You are given an integer array prices representing the prices of various chocolates in a store. You are also given a single integer money, which represents your initial amount of money.

//You must buy exactly two chocolates in such a way that you still have some non-negative leftover money. You would like to minimize the sum of the prices of the two chocolates you buy.

//Return the amount of money you will have leftover after buying the two chocolates. If there is no way for you to buy two chocolates without ending up in debt, return money. Note that the leftover must be non-negative.
namespace LeetCodeProblems;
public partial class LCProblems{
  public int BuyChoco(int[] prices, int money) {
        int least=Int32.MaxValue;
        int secondleast=Int32.MaxValue;

        for(int i=0;i<prices.Length;i++)
        {
            if(prices[i]<=least)
            {
                secondleast=least;
                least=prices[i];
            }
            else if(prices[i]>least&& prices[i]<secondleast)
            {
                secondleast=prices[i];
            }

        }
        if(money-least-secondleast>=0)
        return money-least-secondleast;
        else
        return money;
    }
}
