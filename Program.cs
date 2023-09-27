// See https://aka.ms/new-console-template for more information
using LeetCodeProblems;
using System.Diagnostics;

LCProblems obj=new LCProblems();     
var watch = Stopwatch.StartNew(); 
Console.WriteLine(obj.DecodeAtIndex("ssd1",2));
watch.Stop(); 
Console.WriteLine("Execution Time:"+watch.ElapsedMilliseconds+"ms");
