// 1716. Calculate Money in Leetcode Bank
// Easy

// Hercy saves money for his first car by depositing $1 on Monday and increasing the daily deposit by $1 each day. 
// The pattern repeats every week, with each Monday's deposit being $1 more than the previous Monday. 
// The task is to calculate the total amount of money in Hercy's bank after n days, considering this deposit pattern.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int TotalMoney(int n)
    {
        // An array representing the days of the week, starting from Monday (day[0]) to Sunday (day[6]).
        int[] day = {1, 2, 3, 4, 5, 6, 7};

        // Variable to store the total money accumulated.
        int result = 0;

        // Loop through each day up to 'n'.
        for (int i = 0; i < n; i++) {
            // Accumulate the current day's money to the result.
            result += day[i % 7];

            // Increment the money for the same day in the next week, as the pattern repeats.
            ++day[i % 7];
        }

        // Return the total accumulated money.
        return result;
    }
}