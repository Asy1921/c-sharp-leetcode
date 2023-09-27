namespace LeetCodeProblems;
    
public partial class LCProblems{
    public string DecodeAtIndex(string s, int k)
    {
    long DLen = 0;
    int n = s.Length;

    // Calculate the total decoded length
    for (int i = 0; i < n; i++)
    {
        if (char.IsDigit(s[i]))
        {
           
            DLen *= (s[i] - '0');
        }
        else
        {
            DLen++;
        }
    }

    // Iterate through the string in reverse to find the kth character
    for (int i = n - 1; i >= 0; i--)
    {
        k = (int)(k % DLen); 

        if (k == 0 && char.IsLetter(s[i]))
        {
            return s[i].ToString();
        }

        if (char.IsDigit(s[i]))
        {
            
            DLen /= (s[i] - '0');
        }
        else
        {
            DLen--;
        }
    }

    return ""; 
    }
    }

