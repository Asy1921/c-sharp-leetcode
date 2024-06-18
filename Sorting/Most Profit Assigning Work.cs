// 826. Most Profit Assigning Work
// Solved
// Medium
// Topics
// Companies
// You have n jobs and m workers. You are given three arrays: difficulty, profit, and worker where:

// difficulty[i] and profit[i] are the difficulty and the profit of the ith job, and
// worker[j] is the ability of jth worker (i.e., the jth worker can only complete a job with difficulty at most worker[j]).
// Every worker can be assigned at most one job, but one job can be completed multiple times.

// For example, if three workers attempt the same job that pays $1, then the total profit will be $3. If a worker cannot complete any job, their profit is $0.
// Return the maximum profit we can achieve after assigning the workers to the jobs.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public class tempClassMPAW
    {
        public int profit = 0;
        public int diff = 0;
    }
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {

        int res = 0;
        List<tempClassMPAW> li = new();
        for (int i = 0; i < profit.Length; i++)
        {
            li.Add(new tempClassMPAW()
            {
                profit = profit[i],
                diff = difficulty[i]
            });
        }
        li = li.OrderByDescending(x => x.profit).ToList();

        foreach (tempClassMPAW row in li)
        {
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i] >= row.diff)
                {
                    worker[i] = -1;
                    res += row.profit;
                }
            }
        }
        return res;
    }
}