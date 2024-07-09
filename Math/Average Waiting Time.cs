// 1701. Average Waiting Time
// Solved
// Medium
// Topics
// Companies
// Hint
// There is a restaurant with a single chef. You are given an array customers, where customers[i] = [arrivali, timei]:

// arrivali is the arrival time of the ith customer. The arrival times are sorted in non-decreasing order.
// timei is the time needed to prepare the order of the ith customer.
// When a customer arrives, he gives the chef his order, and the chef starts preparing it once he is idle. The customer waits till the chef finishes preparing his order. The chef does not prepare food for more than one customer at a time. The chef prepares food for customers in the order they were given in the input.

// Return the average waiting time of all customers. Solutions within 10-5 from the actual answer are considered accepted.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public double AverageWaitingTime(int[][] customers)
    {
        int tot_time = 0;
        int c = 0;
        int i = 0;
        double waitTime = 0;

        while (c < customers.Length)
        {
            if (customers[c][0] <= i)
            {
                // Arrival time
                i += customers[c][1];
                waitTime += i - customers[c][0];
                Console.WriteLine(i - customers[c][0]);
                c++;
            }
            else
            {
                i++;
            }

        }
        return (waitTime / customers.Length);


    }
}