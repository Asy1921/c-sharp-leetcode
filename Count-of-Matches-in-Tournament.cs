namespace LeetCodeProblems
{
    // Partial class for LeetCode problems
    public partial class LCProblems
    {
        // Method to calculate the number of matches in a tournament
        public int NumberOfMatches(int n)
        {
            // Initialize the result variable to count the matches
            int result = 0;
            
            // Variable to keep track of the current number of teams in the tournament
            int teamCount = n;

            // Continue the loop until there is only one team left
            while (teamCount > 1)
            {
                // Check if the current number of teams is even
                if (teamCount % 2 == 0)
                {
                    // If even, add half of the teams to the result
                    result += (teamCount / 2);
                    
                    // Update the number of teams to half
                    teamCount /= 2;
                }
                else
                {
                    // If odd, add (teamCount - 1) / 2 to the result
                    result += (teamCount - 1) / 2;
                    
                    // Update the number of teams to (teamCount + 1) / 2
                    teamCount = (teamCount + 1) / 2;
                }
            }

            // Return the total number of matches
            return result;
        }
    }
}
