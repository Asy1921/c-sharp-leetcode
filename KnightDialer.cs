// 935. Knight Dialer
// Medium
// 2.9k
// 63
// Companies
// This C# code addresses the Knight Dialer problem, which involves counting the distinct sequences of moves a knight can make on a phone dialer with n steps.
// The dialer has numeric cells, and the knight follows specific movements, changing its position accordingly. 
// The code uses a recursive approach with memoization to avoid redundant calculations, considering the possible moves from each numeric cell. 
// The main function iterates through all possible starting points, calculating the total count of sequences. The result is returned modulo 1000000007 (MOD). 
// In summary, the code efficiently computes the number of ways a knight can traverse the dialer with n steps while considering the unique movements allowed in a chessboard. 

namespace LeetCodeProblems;

    public partial class LCProblems{
        public int KnightDialer(int n) {
            int MOD = 1000000007;
            
            // Define the possible movements for each numeric cell
            int[][] moves = new int[][]{
                new int[]{4, 6},    // 0
                new int[]{6, 8},    // 1
                new int[]{7, 9},    // 2
                new int[]{4, 8},    // 3
                new int[]{3, 9, 0}, // 4
                new int[]{},        // 5
                new int[]{1, 7, 0}, // 6
                new int[]{2, 6},    // 7
                new int[]{1, 3},    // 8
                new int[]{2, 4}     // 9
            };
            
            // Initialize memoization dictionary to store calculated results
            Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();
            
            int totalCount = 0;
            
            // Loop through each numeric cell as the starting point
            for (int i = 0; i < 10; i++) {
                totalCount = (totalCount + RecursiveCountWays(n - 1, i, moves, memo, MOD)) % MOD;
            }
            
            return totalCount;
        }

        private int RecursiveCountWays(int remainingMoves, int currentNum, int[][] moves, Dictionary<(int, int), int> memo, int MOD) {
            if (remainingMoves == 0) return 1;
            
            if (memo.ContainsKey((remainingMoves, currentNum))) {
                return memo[(remainingMoves, currentNum)];
            }
            
            int totalCount = 0;
            
            foreach (int nextNum in moves[currentNum]) {
                totalCount = (totalCount + RecursiveCountWays(remainingMoves - 1, nextNum, moves, memo, MOD)) % MOD;
            }
            
            memo[(remainingMoves, currentNum)] = totalCount;
            return totalCount;
        }
    }