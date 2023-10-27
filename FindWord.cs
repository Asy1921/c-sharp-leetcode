namespace LeetCodeProblems;
public partial class LCProblems
{
    public static char[][] createAndInitializeCharArray()
    {
        char[][] charArray = new char[][]
    {
        new char[] { 'A', 'B', 'C', 'E' },
        new char[] { 'S', 'F', 'C', 'S' },
        new char[] { 'A', 'D', 'E', 'E' }
    };
        return charArray;
    }
    public bool Exist()
    {
        char[][] board = createAndInitializeCharArray();


        string word = "ABCB";
        bool status = false;

        void FindWord(int i, int j, string cur)
        {
            if (cur == word)
            {
                status = true;
                return;
            }
            if (i >= board.Length || j >= board[0].Length || cur.Length > word.Length)
            {
                return;
            }
            Console.WriteLine(cur);
            cur += board[i][j];
            FindWord(i + 1, j, cur);
            cur.Remove(cur.Length - 1);
            FindWord(i, j + 1, cur);
        }
        FindWord(0, 0, "");
        return status;
    }
}