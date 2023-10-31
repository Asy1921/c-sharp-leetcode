using LeetCodeProblems;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static LeetCodeProblems.LCProblems;

LCProblems obj = new LCProblems();
var watch = Stopwatch.StartNew();

// Console.WriteLine(obj.DecodeAtIndex("ssd1",2));
// Console.WriteLine(obj.SortArrayByParity(new int[]{1,3,5,2,7}));
// Console.WriteLine(obj.IsMonotonic(new int[]{1,3,2}));
// obj.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null)))));
// obj.RemoveNthFromEnd(new ListNode(1, new ListNode(2, null)), 2);
// obj.CopyRandomList();
// obj.WinnerOfGame("AAAAABBBBBBAAAAA");
// Console.WriteLine(obj.NumIdenticalPairs(new int[] { 1, 3, 5, 5, 6, 1 }));
// Console.WriteLine(obj.FindDuplicate(new int[] { 1, 3, 5, 5, 6, 1 }));
// Console.WriteLine(obj.MajorityElement(new int[] { 1, 3, 5, 5, 6, 1 }));
// Console.WriteLine(obj.SingleNumber(new int[] { 1, 3, 5, 5, 6, 1 }));
// Console.WriteLine(obj.Ssubsets(new int[] { 1, 3, 5, 5, 6, 1 }));

// foreach (var item in obj.CombinationSum(new int[] { 1, 3, 5, 5, 6, 1 }, 7).SelectMany(l => l.Select(o => o)))
// {
//     Console.WriteLine(item);
// }
// foreach (var item in obj.CombinationSum2(new int[] { 1, 3, 5, 5, 6, 1 }, 7).SelectMany(l => l.Select(o => o)))
// {
//     Console.WriteLine(item);
// }
foreach (string s in obj.LetterCombinations("23"))
{
    Console.WriteLine(s);
}


watch.Stop();
Console.WriteLine("Execution Time:" + watch.ElapsedMilliseconds + "ms");
