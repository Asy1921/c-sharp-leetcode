//151. Reverse Words in a String
//Medium
//7.6K
//4.9K
//Companies
//Given an input string s, reverse the order of the words.

//A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

//Return a string of the words in reverse order concatenated by a single space.

//Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
namespace LeetCodeProblems;
public partial class LCProblems
{
   public string ReverseWords(string s) {
        List<string> words=s.Split(' ').ToList();
        words.RemoveAll(x=>x=="");
        words.Reverse();
        string res="";
        foreach (string str in words)
        {
            res+=str+" ";
        }
        res=res.Trim();
        return res;
    }

}
