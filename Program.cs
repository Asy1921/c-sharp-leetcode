// See https://aka.ms/new-console-template for more information
using LeetCodeProblems;
using System.Diagnostics;
using static LeetCodeProblems.LCProblems;

LCProblems obj = new LCProblems();
var watch = Stopwatch.StartNew();
// Console.WriteLine(obj.DecodeAtIndex("ssd1",2));
// Console.WriteLine(obj.SortArrayByParity(new int[]{1,3,5,2,7}));
// Console.WriteLine(obj.IsMonotonic(new int[]{1,3,2}));
// obj.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null)))));
obj.RemoveNthFromEnd(new ListNode(1, new ListNode(2, null)), 2);
// new ListNode(3, new ListNode(4, new ListNode(5, null))))), 2);
watch.Stop();
Console.WriteLine("Execution Time:" + watch.ElapsedMilliseconds + "ms");
